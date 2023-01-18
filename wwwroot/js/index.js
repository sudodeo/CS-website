﻿// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

"use strict";

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

// type writer effect
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
