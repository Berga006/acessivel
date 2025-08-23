// script.js


let fonte = 16;


const btnAumentar = document.getElementById('aumentar');
const btnDiminuir = document.getElementById('diminuir');
const btnContraste = document.getElementById('contraste');


btnAumentar.addEventListener('click', () => {
fonte += 2;
document.body.style.fontSize = fonte + 'px';
});


btnDiminuir.addEventListener('click', () => {
if (fonte > 10) {
fonte -= 2;
document.body.style.fontSize = fonte + 'px';
}
});


btnContraste.addEventListener('click', () => {
document.body.classList.toggle('alto-contraste');
});