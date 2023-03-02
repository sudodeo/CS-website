"use strict";

///////////////// Loader //////////////////////
const loader = document.getElementById("loader");

window.addEventListener("load", function () {
  loader.classList.remove("loading");
});

/////////////// NAVBAR //////////////////////
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

/////////////// Show hide menu bar //////////////////////
const menuBtn = document.getElementById("menuBtn");
const menu = document.getElementById("mobileNavigation");
const closeBtn = document.getElementById("closeBtn");
// get all links in the menu
const menuLinks = document.querySelectorAll(".menu_link");

menuBtn.addEventListener("click", function () {
  menu.classList.toggle("show");
});

closeBtn.addEventListener("click", function () {
  menu.classList.toggle("show");
});

// close menu when clicking on a link
menuLinks.forEach(function (link) {
  link.addEventListener("click", function () {
    menu.classList.remove("show");
  });
});

/////////////// learn more button //////////////////////
const learnMoreBtn = document.getElementById("learnMore");
const preamble = document.getElementById("preamble");

learnMoreBtn.addEventListener("click", function () {
  window.scrollTo({
    top: preamble.offsetTop,
    behavior: "smooth",
  });
});

//////////////// TYPEWRITER EFFECT ///////////////////////
const typedTextSpan = document.querySelector(".dynamic_texts");
const strings = [
  "Where technology and innovation meet.",
  "Discover the power of code with our computer science program.",
  "From algorithms to artificial intelligence, we have you covered.",
  "Think beyond the limits of technology with a computer science education.",
  "Transform your future with a computer science degree from our school.",
  "Unlock the secrets of computer science with our innovative program.",
  "Empower yourself with the skills to succeed in the tech industry.",
  "Lead the way in technology with a computer science degree from our department.",
  "Unlock your potential with a computer science degree from our school.",
];

let stringIndex = 0;
let charIndex = 0;

function type() {
  if (charIndex < strings[stringIndex].length) {
    if (!typedTextSpan.classList.contains("typing"))
      typedTextSpan.classList.add("typing");
    typedTextSpan.textContent += strings[stringIndex].charAt(charIndex);
    charIndex++;
    setTimeout(type, 80);
  } else {
    typedTextSpan.classList.remove("typing");
    setTimeout(erase, 1000);
  }
}

function erase() {
  if (charIndex > 0) {
    if (!typedTextSpan.classList.contains("typing"))
      typedTextSpan.classList.add("typing");
    typedTextSpan.textContent = strings[stringIndex].substring(
      0,
      charIndex - 1
    );
    charIndex--;
    setTimeout(erase, 20);
  } else {
    typedTextSpan.classList.remove("typing");
    stringIndex++;
    if (stringIndex >= strings.length) stringIndex = 0;
    setTimeout(type, 1000);
  }
}

document.addEventListener("DOMContentLoaded", function () {
  if (strings.length) setTimeout(type, 1000);
});
