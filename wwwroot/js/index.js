// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Show navbar on scroll up and hide on scroll down
let lastScrollTop = 0;
const navbar = document.getElementById("navbar");
const logo = document.getElementById("logo");

window.addEventListener("scroll", function () {
  const scrollTop = window.pageYOffset || document.documentElement.scrollTop;
  if (scrollTop == 0) {
    // at top, remove background color & change logo
    logo.setAttribute("src", "/images/logo-light.png");
    navbar.classList.remove("activate_scroll");
    navbar.style.backgroundColor = "transparent";
  } else if (scrollTop > lastScrollTop) {
    // Scroll down
    navbar.classList.add("activate_scroll");
    navbar.style.top = "-120px";
  } else {
    // Scroll up
    logo.setAttribute("src", "/images/logo-dark.png");
    navbar.style.top = "0";
    navbar.style.backgroundColor = "white";
  }
  lastScrollTop = scrollTop;
});
