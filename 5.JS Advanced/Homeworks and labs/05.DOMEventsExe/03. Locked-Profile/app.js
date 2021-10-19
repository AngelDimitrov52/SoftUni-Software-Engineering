function lockedProfile() {
    let allButtonsElemets = Array.from(document.querySelectorAll('button'));

    allButtonsElemets.forEach(botton => {

        botton.addEventListener('click', (e) => {

            let parentDiv = e.target.parentElement;
            let moreInfoElemet = parentDiv.getElementsByTagName('div')[0];
            const lockStatus = parentDiv.querySelector('input[type="radio"]:checked').value;

            if (lockStatus === 'unlock') {
                if (botton.textContent === 'Hide it') {
                    botton.textContent = 'Show more';
                    moreInfoElemet.style.display = 'none'
                }
                else {
                    moreInfoElemet.style.display = 'block'
                    botton.textContent = 'Hide it';

                }
            }

        })

    });

}