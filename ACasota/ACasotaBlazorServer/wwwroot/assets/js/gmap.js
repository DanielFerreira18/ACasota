let map;
let latLabel;
let lngLabel;
let streetLabel;
let cityLabel;
let marker;

function initMapStaticReport(latitude, longitude) {
    // Initialize the map
    map = new google.maps.Map(document.getElementById("map"), {
        center: { lat: latitude, lng: longitude }, // Coordinates for Guarda, Portugal
        zoom: 20,
        mapTypeId: 'hybrid',
    });

    addMarkerStaticReport(latitude, longitude);
}

function initMap() {
    // Initialize the map
    map = new google.maps.Map(document.getElementById("map"), {
        center: { lat: 40.538498, lng: -7.269666 }, // Coordinates for Guarda, Portugal
        zoom: 16,
        mapTypeId: 'hybrid',
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

function addMarkerStaticReport(latitude, longitude) {
    // Remove the previous marker, if exists
    if (marker) {
        marker.setMap(null);
    }

    // Create a marker with the specified location
    marker = new google.maps.Marker({
        position: { lat: latitude, lng: longitude },
        map: map,
        icon: {
            url: "http://maps.google.com/mapfiles/ms/icons/red-dot.png",
        },
    });
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

function removeEverything() {
    if (marker) {
        marker.setMap(null);
    }

    document.getElementById("latLabel").textContent = "Latitude da localização";
    document.getElementById("lngLabel").textContent = "Longitude da localização";
    document.getElementById("cityLabel").textContent = "Cidade";
    document.getElementById("streetLabel").textContent = "Morada completa";
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

function GetInfoReportLatitude() {
    return document.getElementById("latLabel").textContent;
}

function GetInfoReportLongitude() {
    return document.getElementById("lngLabel").textContent;
}

function GetInfoReportCity() {
    return document.getElementById("cityLabel").textContent;
}

function GetInfoReportStreet() {
    return document.getElementById("streetLabel").textContent;
}