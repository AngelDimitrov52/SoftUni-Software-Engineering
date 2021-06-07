function solve() {
   document.querySelector('#searchBtn').addEventListener('click', onClick);

   function onClick() {

      let tableRowElemets = Array.from(document.querySelectorAll('tbody tr'));
      let input = document.getElementById('searchField').value;

      tableRowElemets.forEach(el => {
         el.className = '';

      });

      tableRowElemets.forEach(el => {
         let valueRow = Array.from(el.children);

         if (valueRow.some(x => x.textContent.includes(input))) {
            el.className = 'select'
         }

      });
      document.getElementById('searchField').value = '';

   }
}