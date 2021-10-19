function loadRepos() {
   const xmlElemet = new XMLHttpRequest();
 
   xmlElemet.addEventListener('readystatechange', () => {
      if(xmlElemet.readyState === 4 && xmlElemet.status === 200) {
         let res = document.getElementById('res');
         res.innerHTML = xmlElemet.responseText
      }
   })
   xmlElemet.open('GET',`https://api.github.com/users/testnakov/repos`);
   xmlElemet.send();
}