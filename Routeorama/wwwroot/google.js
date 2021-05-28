var city;
var country;
var coords;
var address;
var result;
var name;
var map;
var wrapper;
var markers = [];
let latitude = 48.855348;
let longitude = 2.344311;

getLocation();

async function initMap() {
    const actualPos = {lat: latitude, lng: longitude};
    console.log(actualPos);
    map = new google.maps.Map(document.getElementById("map"), {
        zoom: 8,
        center: actualPos,
        disableDefaultUI: true,
        zoomControl: true,
        streetViewControl: true
    });


    // Create the initial InfoWindow.
    let infoWindow = new google.maps.InfoWindow({
        position: actualPos,
        content: "Welcome to Routeorama!"
    });
    infoWindow.open(map);

    //Configure listener for bounds
    google.maps.event.addListener(map, 'idle', function (event) {
        var bounds = map.getBounds();

        var ne = bounds.getNorthEast();
        var sw = bounds.getSouthWest();

        if (map.getZoom() <= 6) {
            clearMarkers();
        } else {
            ChangeValueFromJs(ne.lat(), ne.lng(), sw.lat(), sw.lng());
        }
    });

    // Configure the click listener.
    map.addListener("click", (mapsMouseEvent) => {
        // Close the current InfoWindow.
        infoWindow.close();
        // Create a new InfoWindow.
        infoWindow = new google.maps.InfoWindow({
            position: mapsMouseEvent.latLng,
        });
        infoWindow.open(map);
        var geocoder = new google.maps.Geocoder();
        geocode(geocoder, map, infoWindow, mapsMouseEvent.latLng);
    });
}

function geocode(geocoder, map, infoWindow, latLng) {
    geocoder.geocode({location: latLng}, (results, status) => {
        if (status === "OK") {
            if (results[0]) {
                infoWindow.setContent(
                    "<div style='display: flex; justify-content: space-around; align-items: flex-start; flex-direction: column'>" +
                    results[0].formatted_address +
                    "<br><br>" +
                    "<button id='modal-button' style='border: none;\n" +
                    "    background-color: dodgerblue;\n" +
                    "    color: white;" +
                    "    border-radius: 5px;" +
                    "    padding: 5px 10px'>Add place</button>" +
                    "</div>"
                );
                infoWindow.open(map);
                var modal = document.getElementById("myModal");
                var btn = document.getElementById("modal-button");
                var span = document.getElementsByClassName("exit")[0];
                city = document.getElementById("city");
                country = document.getElementById("country");
                //name = document.getElementById("name");
                coords = document.getElementById("coords");

                coords.value = results[0].geometry.location;
                address = results[0].address_components;

                result = results[0];
                address.forEach((item) => {

                    if (item.types.includes("locality")) {
                        city.value = item.long_name;
                    }
                    if (item.types.includes("country")) {
                        country.value = item.long_name;
                    }
                });
                console.log(name.value);

                btn.onclick = function () {
                    modal.style.display = "flex";
                }
                span.onclick = function () {
                    modal.style.display = "none";
                }
                window.onclick = function (event) {
                    if (event.target === modal) {
                        modal.style.display = "none";
                    }
                }
            }
        }
    });
}

function ChangeValueFromJs(NELat, NELng, SWLat, SWLng) {
    return wrapper.invokeMethodAsync("invokeFromJS", NELat, NELng, SWLat, SWLng);
}

function setWrapper(wrapper1) {
    wrapper = wrapper1;
}

function clearMarkers() {
    //Loop through all the markers and remove
    for (var i = 0; i < markers.length; i++) {
        markers[i].setMap(null);
    }
    markers = [];
}

var selectedInfoWindow;

function MakeMarker(id3, name3, description3, userId3, followCount3,
                    city3, country3, lat3, lng3) {
    console.log("created markers");
    var myLatLng = new google.maps.LatLng(lat3, lng3);
    const contentString =
        '<div id="content">' +
        '<h1 id="firstHeading" class="firstHeading" style="font-size: 20px;">' + name3 + '</h1>' +
        '<div id="bodyContent">' +
        "<p><b>" + name3 + "</b>, " + description3 + "</p>" +
        "</div>" +
        "<button style='border: none;\n" +
        "               background-color: dodgerblue;\n" +
        "               color: white;    " +
        "               border-radius: 5px;    " +
        "               padding: 5px 10px' " +
        "onclick=\"navigateToChannel()\" >Go to channel</button>" +
        "</div>";

    let infoWindow = new google.maps.InfoWindow({
        position: myLatLng, content: contentString
    });

    var myMarkerOptions = {
        position: myLatLng,
        map: map,
        animation: google.maps.Animation.DROP
    }

    var myMarker = new google.maps.Marker(myMarkerOptions);

    google.maps.event.addListener(myMarker, "click", function () {
        //Check if there some info window selected and if is opened then close it
        if (selectedInfoWindow != null && selectedInfoWindow.getMap() != null) {
            selectedInfoWindow.close();
            //If the clicked window is the selected window, deselect it and return
            if (selectedInfoWindow == infoWindow) {
                selectedInfoWindow = null;
                return;
            }
        }
        //If arrive here, that mean you should open the new info window 
        //because is different from the selected
        selectedInfoWindow = infoWindow;
        selectedInfoWindow.open(map, myMarker);
    });

    markers.push(myMarker);
}

function navigateToChannel() {
    var asdf = document.getElementById("firstHeading").innerHTML;
    wrapper.invokeMethodAsync("channel", asdf);
}

function FetchCity() {
    return city.value;
}

function FetchCountry() {
    return country.value;
}


function FetchCoordinates() {
    return coords.value;
}

function ClearData() {
    coords.value = "";
    country.value = "";
    city.value = "";
}

function getLocation() {
    if (navigator.geolocation) {
        navigator.geolocation.getCurrentPosition(success, error);
    } else {
        console.log("not supported in browser")
    }
}

function error() {
    console.log("shit hit the fan");
}

function success(position) {
    latitude = position.coords.latitude;
    longitude = position.coords.longitude;
}


