function create(words) {

   let perantDiv = document.getElementById('content');
   words.forEach(el => {
      let divElemet = document.createElement('div');
      let pElemet = document.createElement('p');
      pElemet.textContent = el;
      pElemet.style.display = 'none';
      divElemet.appendChild(pElemet);
      divElemet.addEventListener('click', (e) => {
         console.log( e.target.children[0]);
         e.target.children[0].style.display = 'block';
      })
      perantDiv.appendChild(divElemet);

   });



}