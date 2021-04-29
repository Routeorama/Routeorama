﻿function initMap() {
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

function geocode(geocoder, map, infoWindow, latLng){
    geocoder.geocode({ location: latLng}, (results, status) => {
        if(status === "OK"){
            if(results[0]){
                // var marker = new google.maps.Marker({
                //     position: latLng,
                //     map: map
                // });
                infoWindow.setContent(results[0].formatted_address);
                infoWindow.open(map);
            }
        }
    });
}
