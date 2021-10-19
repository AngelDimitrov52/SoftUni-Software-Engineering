function notify(message) {
  let divElemet = document.getElementById('notification');
  divElemet.textContent = message;
  console.log(divElemet.textContent);
  divElemet.style.display = 'block';

  divElemet.addEventListener('click', () => {
    divElemet.style.display = 'none';
  });
}