﻿let map;
let latLabel;
let lngLabel;
let streetLabel;
let cityLabel;
let marker;

function initMap() {
    // Initialize the map
    map = new google.maps.Map(document.getElementById("map"), {
        center: { lat: 40.538498, lng: -7.269666 }, // Coordinates for Guarda, Portugal
        zoom: 16,
    });

    // Initialize the labels
    latLabel = document.getElementById("latLabel");
    lngLabel = document.getElementById("lngLabel");
    streetLabel = document.getElementById("streetLabel");
    cityLabel = document.getElementById("cityLabel");

    // Add a click event listener to the map
    map.addListener("click", (event) => {
        displayCoordinates(event.latLng.lat(), event.latLng.lng());
        addMarker(event.latLng);
        getAddress(event.latLng);
    });
}

function displayCoordinates(lat, lng) {
    // Update the labels with the coordinates
    latLabel.textContent = lat.toFixed(6);
    lngLabel.textContent = lng.toFixed(6);
}

function addMarker(location) {
    // Remove the previous marker, if exists
    if (marker) {
        marker.setMap(null);
    }

    // Create a marker with the specified location
    marker = new google.maps.Marker({
        position: location,
        map: map,
        icon: {
            url: "http://maps.google.com/mapfiles/ms/icons/red-dot.png",
        },
    });
}

function getAddress(location) {
    // Create a geocoder object
    const geocoder = new google.maps.Geocoder();

    // Retrieve the address information based on the clicked location
    geocoder.geocode({ location: location }, (results, status) => {
        if (status === "OK" && results[0]) {
            const addressComponents = results[0].address_components;

            let street = "";
            let city = "";

            // Extract the street, city, and zip code from the address components
            for (let i = 0; i < addressComponents.length; i++) {
                const types = addressComponents[i].types;
                if (types.includes("street_number")) {
                    street += addressComponents[i].long_name + " ";
                } else if (types.includes("route")) {
                    street += addressComponents[i].long_name;
                } else if (types.includes("locality")) {
                    city = addressComponents[i].long_name;
                }
            }

            // Update the labels with the address information
            streetLabel.textContent = street;
            cityLabel.textContent = city;
        } else {
            // Clear the labels if address retrieval fails
            streetLabel.textContent = "";
            cityLabel.textContent = "";
        }
    });
}