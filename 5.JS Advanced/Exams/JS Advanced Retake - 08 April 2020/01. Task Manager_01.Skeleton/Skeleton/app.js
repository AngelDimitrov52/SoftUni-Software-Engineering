function solve() {
    let addButton = document.getElementById('add');
    addButton.addEventListener('click', addElemetToOpen)

    function addElemetToOpen(e) {
        e.preventDefault();
        let taskElemet = document.getElementById('task').value;
        let descriptionElemet = document.getElementById('description').value;
        let dateElemet = document.getElementById('date').value;

        if (taskElemet == '' || descriptionElemet == '' || dateElemet == '') {
            return;
        }

        let article = document.createElement('article');

        let h3 = document.createElement('h3');
        h3.textContent = taskElemet;

        let pdescriptionElemet = document.createElement('p');
        pdescriptionElemet.textContent = 'Description: ' + descriptionElemet;

        let dateElemetElemet = document.createElement('p');
        dateElemetElemet.textContent = 'Due Date: ' + dateElemet;

        let div = document.createElement('div');
        div.classList.add('flex');

        let startButton = document.createElement('button');
        startButton.classList.add('green');
        startButton.textContent = 'Start';
        startButton.addEventListener('click', removeToInProgres);

        let deleteButton = document.createElement('button');
        deleteButton.classList.add('red');
        deleteButton.textContent = 'Delete';
        deleteButton.addEventListener('click', deleteArticle);

        div.appendChild(startButton);
        div.appendChild(deleteButton);

        article.appendChild(h3);
        article.appendChild(pdescriptionElemet);
        article.appendChild(dateElemetElemet);
        article.appendChild(div);

        let opernSectoin = document.querySelector('body > main > div > section:nth-child(2) > div:nth-child(2)');
        opernSectoin.appendChild(article);
    }
    function deleteArticle(e) {
        let article = e.target.parentElement.parentElement;
        article.remove();

    }
    function removeToInProgres(e) {
        let div = e.target.parentElement;
        let startButton = div.querySelector('.green');


        let finishButton = document.createElement('button');
        finishButton.classList.add('orange');
        finishButton.textContent = 'Finish';
        finishButton.addEventListener('click', finishTask)

        div.appendChild(finishButton);

        let article = e.target.parentElement.parentElement;
        startButton.remove();
        let inProgresDiv = document.getElementById('in-progress');
        inProgresDiv.appendChild(article);
    }
    function finishTask(e) {
        let article = e.target.parentElement.parentElement;
        let div = e.target.parentElement;
        div.remove();

        let finishSection = document.querySelector('body > main > div > section:nth-child(4) > div:nth-child(2)');

        finishSection.appendChild(article);
    }
}