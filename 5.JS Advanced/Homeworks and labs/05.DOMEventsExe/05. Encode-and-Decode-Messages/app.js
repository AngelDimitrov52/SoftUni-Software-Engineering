function encodeAndDecodeMessages() {
    let messageElement = document.querySelectorAll('#main div textarea')[0];
    let codeElemet = document.querySelectorAll('#main div textarea')[1];

    let inputButton = document.querySelectorAll('#main div button')[0];
    let codeBottun = document.querySelectorAll('#main div button')[1];

    let conteinerArr = [];

    inputButton.addEventListener('click', (e) => {

        let text = messageElement.value;
        let codeText = '';

        for (let index = 0; index < text.length; index++) {
            let el = text.charCodeAt(index) + 1;
            codeText += String.fromCharCode(el)
        }

        conteinerArr.push(codeText)
        messageElement.value = '';
        codeElemet.textContent += codeText + '\n';

    });

    codeBottun.addEventListener('click', (e) => {
        let uncodeArr = [];
        for (let index = 0; index < conteinerArr.length; index++) {

            let codeText = '';

            for (let i = 0; i < conteinerArr[index].length; i++) {
                let el = conteinerArr[index].charCodeAt(i) - 1;
                codeText += String.fromCharCode(el)
            }
            uncodeArr.push(codeText)
        }
        codeElemet.textContent = uncodeArr.join('\n')

    });
}