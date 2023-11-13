const loginButton = document.querySelector('.login-button');
const loginPopup = document.querySelector('.login-popup');
const loginPopupClose = document.querySelector('.login-popup-close');

loginButton.addEventListener('click', () => {
    loginPopup.style.display = 'block';
});

loginPopupClose.addEventListener('click', () => {
    loginPopup.style.display = 'none';
});