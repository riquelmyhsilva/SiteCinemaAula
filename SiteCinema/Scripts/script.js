// JavaScript Document

const buttonBarbie = document.getElementById('button-barbie');

buttonBarbie.addEventListener('click', function () {
    window.location.href = '/Home/movieBarbie';
});

const buttonBezouroAzul = document.getElementById('button-bezouro-azul');

buttonBezouroAzul.addEventListener('click', function () {
    window.location.href = '/Home/movieBezouroAzul';
});

const buttonMissaoImpossivel = document.getElementById('button-missao-impossivel');

buttonMissaoImpossivel.addEventListener('click', function () {
    window.location.href = '/Home/filmeIndisponivel';
});

const buttonHomemAranhaAav = document.getElementById('button-homem-aranha-aav');

buttonHomemAranhaAav.addEventListener('click', function () {
    window.location.href = '/Home/filmeIndisponivel';
});

const buttonElementos = document.getElementById('button-elementos');

buttonElementos.addEventListener('click', function () {
    window.location.href = '/Home/filmeIndisponivel';
});

const buttonDuna = document.getElementById('button-duna');

buttonDuna.addEventListener('click', function () {
    window.location.href = '/Home/filmeIndisponivel';
});

const buttonOppenheimer = document.getElementById('button-oppenheimer');

buttonOppenheimer.addEventListener('click', function () {
    window.location.href = '/Home/filmeIndisponivel';
});

const buttonSobrenatural = document.getElementById('button-sobrenatural');

buttonSobrenatural.addEventListener('click', function () {
    window.location.href = '/Home/filmeIndisponivel';
});

const buttonTartarugasNCM = document.getElementById('button-tartarugas-ncm');

buttonTartarugasNCM.addEventListener('click', function () {
    window.location.href = '/Home/filmeIndisponivel';
});

const buttonIconDolby = document.getElementById('icon-dolby');

buttonIconDolby.addEventListener('click', function () {
    window.location.href = '/Home/Index';
});

const buttonMenu = document.getElementById('button-menu');

buttonMenu.addEventListener('click', function () {
    window.location.href = '/Home/Index';
});

const slider = document.querySelector('.slider');
const slides = document.querySelectorAll('.slide');
const leftArrow = document.querySelector('.left-arrow');
const rightArrow = document.querySelector('.right-arrow');
let currentSlide = 0;

function showSlide(index) {
    slides.forEach((slide, i) => {
        if (i === index) {
            slide.style.display = 'block';
        } else {
            slide.style.display = 'none';
        }
    });
}

function nextSlide() {
    currentSlide++;
    if (currentSlide >= slides.length) {
        currentSlide = 0;
    }
    showSlide(currentSlide);
}

function prevSlide() {
    currentSlide--;
    if (currentSlide < 0) {
        currentSlide = slides.length - 1;
    }
    showSlide(currentSlide);
}

leftArrow.addEventListener('click', prevSlide);
rightArrow.addEventListener('click', nextSlide);

showSlide(currentSlide);