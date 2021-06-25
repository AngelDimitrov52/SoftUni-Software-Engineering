function solve() {
   let buttonElemet = document.querySelector('aside section button')
   buttonElemet.addEventListener('click', AddPost)

   function AddPost(e) {
      e.preventDefault();
      let autorElemet = document.getElementById('creator').value;
      let titileElemet = document.getElementById('title').value;
      let categoryElemet = document.getElementById('category').value;
      let contentElemet = document.getElementById('content').value;

      let article = document.createElement('article');

      let h1 = document.createElement('h1');
      h1.textContent = titileElemet;

      let pCategory = document.createElement('p');
      pCategory.textContent = 'Category:';
      let pCategoryStrong = document.createElement('strong');
      pCategoryStrong.textContent = categoryElemet;
      pCategory.appendChild(pCategoryStrong);

      let pCreator = document.createElement('p');
      pCreator.textContent = 'Creator:';
      let pCreatorStrong = document.createElement('strong');
      pCreatorStrong.textContent = autorElemet;
      pCreator.appendChild(pCreatorStrong);

      let pContent = document.createElement('p');
      pContent.textContent = contentElemet;

      let divButtons = document.createElement('div');
      divButtons.classList.add('buttons')
      let deleteButton = document.createElement('button');
      deleteButton.textContent = 'Delete';
      deleteButton.classList.add('btn');
      deleteButton.classList.add('delete');
      deleteButton.addEventListener('click', deleteArticle)
      let arhiveButton = document.createElement('button');
      arhiveButton.textContent = 'Archive';
      arhiveButton.classList.add('btn');
      arhiveButton.classList.add('archive');
      arhiveButton.addEventListener('click', archiveElemet)
      divButtons.appendChild(deleteButton);
      divButtons.appendChild(arhiveButton);

      article.appendChild(h1);
      article.appendChild(pCategory);
      article.appendChild(pCreator);
      article.appendChild(pContent);
      article.appendChild(divButtons);

      let postElemet = document.querySelector('main section');
      postElemet.appendChild(article);

   }

   function deleteArticle(e) {
      let del = e.target.parentElement.parentElement;
      del.remove();

   }
   function archiveElemet(e) {
      let archiveElemet = e.target.parentElement.parentElement;
      let arhiveOl = document.querySelector('.archive-section ol');

      let title = archiveElemet.querySelector('h1').textContent;
      let li = document.createElement('li');
      li.textContent = title;

      archiveElemet.remove();


      let allLi = Array.from(arhiveOl.querySelectorAll('li'));
      allLi.push(li);
      allLi.sort((a, b) => a.textContent.localeCompare(b.textContent))
         .forEach(liItem => arhiveOl.appendChild(liItem));
   }
}
