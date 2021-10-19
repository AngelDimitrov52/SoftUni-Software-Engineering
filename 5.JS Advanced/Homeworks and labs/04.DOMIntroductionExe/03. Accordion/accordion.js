function toggle() {
    let bouttonElemnet = document.getElementsByClassName('button')[0];

    let bottonCommand = bouttonElemnet.textContent;

    let ekstraElemet = document.getElementById("extra");

    if (bottonCommand === 'More') {
        bouttonElemnet.textContent = 'Less';

        ekstraElemet.style.display = 'block';
    }
    else {
        bouttonElemnet.textContent = 'More';
        ekstraElemet.style.display = 'none';
    }
}