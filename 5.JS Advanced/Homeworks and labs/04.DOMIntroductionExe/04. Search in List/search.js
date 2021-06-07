function search() {
   let listItemsElements = document.querySelectorAll('#towns li');
   let listItemsArr = Array.from(listItemsElements);

   listItemsArr.map(x => {

      x.style.fontWeight ='normal';
      x.style.textDecoration = 'none';
   });

   let match = document.getElementById('searchText').value;

   let machesFilter = listItemsArr.filter(x => x.textContent.includes(match))

   machesFilter.map(x => {

      x.style.fontWeight ='bold';
      x.style.textDecoration = 'underline';
   });

     let result = document.getElementById('result');
     result.textContent = `${machesFilter.length} matches found`;
}
