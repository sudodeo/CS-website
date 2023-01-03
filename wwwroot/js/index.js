// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Show navbar on scroll up and hide on scroll down
let lastScrollTop = 0;
const navbar = document.getElementById("navbar");
window.addEventListener("scroll", function () {
  navbar.classList.add("activate_scroll");
  const scrollTop = window.pageYOffset || document.documentElement.scrollTop;
  if (scrollTop == 0) {
    // at top, remove background color
    navbar.style.backgroundColor = "transparent";
  } else if (scrollTop > lastScrollTop) {
    // Scroll down
    navbar.style.top = "-120px";
  } else {
    // Scroll up
    navbar.style.top = "0";
    navbar.style.backgroundColor = "white";
  }
  lastScrollTop = scrollTop;
});
