function solve() {
    let allInputs = Array.from(document.querySelectorAll('#container input'));
    let onScreenButton = document.querySelector('#container button');

    onScreenButton.addEventListener('click', movesOnScreen)

    function movesOnScreen(e) {
        e.preventDefault();

        let name = allInputs[0].value;
        let hall = allInputs[1].value;
        let price = allInputs[2].value;

        if (name.trim() != '' &&
            hall.trim() != '' &&
            price.trim() != '' &&
            !isNaN(Number(price))) {

            price = Number(allInputs[2].value).toFixed(2);

            let liElemet = document.createElement('li');

            let nameSpan = document.createElement('span');
            nameSpan.textContent = name;

            let hallStrong = document.createElement('strong');
            hallStrong.textContent = `Hall: ${hall}`;

            let divElemet = document.createElement('div');

            let priceStrong = document.createElement('strong');
            priceStrong.textContent = price;

            let input = document.createElement('input');
            input.setAttribute('placeholder', 'Tickets Sold')

            let button = document.createElement('button');
            button.addEventListener('click', archiveMovie)
            button.textContent = 'Archive';

            liElemet.appendChild(nameSpan);
            liElemet.appendChild(hallStrong);

            divElemet.appendChild(priceStrong);
            divElemet.appendChild(input);

            divElemet.appendChild(button);

            liElemet.appendChild(divElemet);

            let parentUL = document.querySelector('#movies ul');
            parentUL.appendChild(liElemet);


            allInputs[0].value = '';
            allInputs[1].value = '';
            allInputs[2].value = '';
        }
    }
    function archiveMovie(e) {



        let liElemet = e.target.parentElement.parentElement;
        let strongElement = liElemet.querySelector('strong');
        let inputElemet = liElemet.querySelector('div input').value;

        if (inputElemet.trim() != '' &&
            !isNaN(Number(inputElemet))) {
            let priceElemet = liElemet.querySelector('div strong').textContent;
            let totalPrice = (Number(inputElemet) * Number(priceElemet)).toFixed(2);
            strongElement.textContent = `Total amount: ${totalPrice}`;
            let divElemet = liElemet.querySelector('div');
            divElemet.remove();
            let deleteButton = document.createElement('button');
            deleteButton.textContent = 'Delete';
            deleteButton.addEventListener('click', deletFromArhive)
            liElemet.appendChild(deleteButton)

            let clearSection = document.querySelector('#archive ul');
            clearSection.appendChild(liElemet);
        }

    }
    function deletFromArhive(e) {
        let movie = e.target.parentElement;
        movie.remove();
    }
    let clearButon = document.querySelector('#archive  button')
    clearButon.addEventListener('click', clearAllMovies);

    function clearAllMovies(e) {
        let sectionElemet = e.target.parentElement;
        let allLi = sectionElemet.querySelectorAll('ul li')
        Array.from(allLi).map(e => e.remove());
    }
}