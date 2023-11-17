const loginButton = document.querySelector('.login-button');
const loginPopup = document.querySelector('.login-popup');
const loginPopupClose = document.querySelector('.login-popup-close');
document.querySelector('.homebutton');
loginButton.addEventListener('click', () => {
    loginPopup.style.display = 'block';
});

loginPopupClose.addEventListener('click', () => {
    loginPopup.style.display = 'none';
});
// Initialize and add the map
let map;

async function initMap() {
  // The location of Uluru
  const position = { lat: -25.344, lng: 131.031 };
  // Request needed libraries.
  //@ts-ignore
  const { Map } = await google.maps.importLibrary("maps");
  const { AdvancedMarkerElement } = await google.maps.importLibrary("marker");

  // The map, centered at Uluru
  map = new Map(document.getElementById("map"), {
    zoom: 4,
    center: position,
    mapId: "DEMO_MAP_ID",
  });

  // The marker, positioned at Uluru
  const marker = new AdvancedMarkerElement({
    map: map,
    position: position,
    title: "Uluru",
  });
}

initMap();
// The location of Uluru
const position = { lat: -25.344, lng: 131.031 };
// Request needed libraries.
//@ts-ignore
const { Map } = await google.maps.importLibrary("maps");


// The map, centered at Uluru
map = new Map(document.getElementById("map"), {
  zoom: 4,
  center: position,
  mapId: "DEMO_MAP_ID",
});
function msgAlert() {
  const msgSent = "Message Sent!";
  alert (msgSent);
}

function openLoginModal() {
  document.getElementById('loginModal').style.display = 'flex';
}

function closeLoginModal() {
  document.getElementById('loginModal').style.display = 'none';
}