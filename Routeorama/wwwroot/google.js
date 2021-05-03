
var descriptionOfThePlace;
var city;
var country;
var placesCoordinates;
var placesLat;
var placesLng;
var coords;
var address;
var result;
var name;

function initMap() {
    const myLatlng = {lat: -25.363, lng: 131.044};
    const map = new google.maps.Map(document.getElementById("map"), {
        zoom: 4,
        center: myLatlng,
        disableDefaultUI: true,
        zoomControl: true,
        streetViewControl: true
    });
    // Create the initial InfoWindow.
    let infoWindow = new google.maps.InfoWindow({
        position: myLatlng,
        content: "Welcome to Routeorama!"
    });
    infoWindow.open(map);
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
                // var marker = new google.maps.Marker({
                //     position: latLng,
                //     map: map
                // });
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
                //unfortunately this needs to be here since the button isn't rendered until someone clicks on the map
                var modal = document.getElementById("myModal");
                var btn = document.getElementById("modal-button");
                var span = document.getElementsByClassName("exit")[0];
                city = document.getElementById("city");
                country = document.getElementById("country");
                //name = document.getElementById("name");
                coords = document.getElementById("coords");

                coords.value = results[0].geometry.location;
                //placesCoordinates = results[0].geometry.location;

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


