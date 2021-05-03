﻿function fetchWeather(lat, lng) {
    var key = '8f5b10c2df67380b924b2e5e69e6bb42';
    fetch('https://api.openweathermap.org/data/2.5/weather?lat=' + lat + '&lon=' + lng + '&appid=' + key)
        .then(function (resp) {
            return resp.json()
        }) // Convert data to json
        .then(function (data) {
            console.log(data)
            drawWeather(data);
        })
        .catch(function () {
            // catch any errors
        });
}

function drawWeather(d) {
    var celcius = Math.round(parseFloat(d.main.temp) - 273.15);
    var feelslike = Math.round(parseFloat(d.main.feels_like) - 273.15);
    var description = d.weather[0].description;
    var pressure1 = Math.round(parseFloat(d.main.pressure) - 273.15);
    console.log(celcius);
    console.log(description);


    var sec = d.sys.sunrise;
    var date = new Date(sec * 1000);
    var sunrise = date.toLocaleTimeString();

    var sec1 = d.sys.sunset;
    var date1= new Date(sec1 * 1000);
    var sunset = date1.toLocaleTimeString();
    

    document.getElementById('description').innerHTML = description;
    document.getElementById('temp').innerHTML = celcius + '&deg;';
    document.getElementById('feels_like').innerHTML = feelslike + '&deg;';
    document.getElementById('sunrise').innerHTML = sunrise;
    document.getElementById('sunset').innerHTML = sunset;
    document.getElementById('pressure').innerHTML = pressure1 + " hPa";
    document.getElementById('location').innerHTML = d.name;

    if (description.indexOf('rain') > 0) {
        document.body.className = 'rainy';
    } else if (description.indexOf('cloud') > 0) {
        document.body.className = 'cloudy';
    } else if (description.indexOf('sunny') > 0) {
        document.body.className = 'sunny';
    }
}

