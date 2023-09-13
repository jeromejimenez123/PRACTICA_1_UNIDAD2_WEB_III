// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.
// carousel.js
let slideIndex = 0;

function showSlide(n) {
    const slides = document.getElementsByClassName("carousel-slide");
    if (n < 0) {
        slideIndex = slides.length - 1;
    } else if (n >= slides.length) {
        slideIndex = 0;
    }
    for (let i = 0; i < slides.length; i++) {
        slides[i].style.display = "none";
    }
    slides[slideIndex].style.display = "block";
}

function nextSlide() {
    slideIndex++;
    showSlide(slideIndex);
}

function prevSlide() {
    slideIndex--;
    showSlide(slideIndex);
}

document.addEventListener("DOMContentLoaded", function () {
    showSlide(slideIndex);
    setInterval(nextSlide, 3000); // Cambia la imagen cada 3 segundos
});
