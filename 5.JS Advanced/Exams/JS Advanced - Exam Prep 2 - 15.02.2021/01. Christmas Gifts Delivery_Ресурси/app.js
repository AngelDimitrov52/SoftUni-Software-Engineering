function solution() {
    let addGifButton = document.querySelector('.container div button');
    addGifButton.addEventListener('click', addGifList)

    function addGifList(e) {
        let gifTextElemet = document.querySelector('.container div input');
        if (gifTextElemet.value === '') {
            return
        }

        let liElemt = document.createElement('li');
        liElemt.classList.add('gift');
        liElemt.textContent = gifTextElemet.value;
        gifTextElemet.value = '';

        let sendButton = document.createElement('button')
        sendButton.id = 'sendButton';
        sendButton.textContent = 'Send';
        sendButton.addEventListener('click', sendGif)

        let discardButton = document.createElement('button')
        discardButton.id = 'discardButton';
        discardButton.textContent = 'Discard';
        discardButton.addEventListener('click', discardGif)

        liElemt.appendChild(sendButton);
        liElemt.appendChild(discardButton);

        let allUl = document.querySelector('body > div > section:nth-child(2) > ul ');
        let allUlElemt = Array.from(document.querySelectorAll('body > div > section:nth-child(2) > ul li'));
        allUlElemt.push(liElemt);

        allUlElemt
            .sort((a, b) => a.textContent.localeCompare(b.textContent))
            .forEach(li => allUl.appendChild(li));
    }

    function sendGif(e) {
      
        let item = e.target.parentNode;
        item.lastElementChild.remove();
        item.lastElementChild.remove();

        let sendSectionElemt = document.querySelector('body > div > section:nth-child(3) > ul');
        sendSectionElemt.appendChild(item);

    }
    function discardGif(e) {
        let item = e.target.parentNode;
        item.lastElementChild.remove();
        item.lastElementChild.remove();

        let sendSectionElemt = document.querySelector('body > div > section:nth-child(4) > ul');
        sendSectionElemt.appendChild(item);

    }

}