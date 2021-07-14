function attachEvents() {
    let refreshButton = document.getElementById('refresh');
    refreshButton.addEventListener('click', refreshFunc);
    let textArea = document.getElementById('messages')
    let submitButton = document.getElementById('submit');
    submitButton.addEventListener('click', submitFunc);
    let url = 'http://localhost:3030/jsonstore/messenger';

    async function refreshFunc() {
        let fetchGet = await fetch(url);
        let message = await fetchGet.json();
        textArea.value = '';

        for (const key in message) {
            textArea.value += `${message[key].author}: ${message[key].content}\n`;
        }
    }

    async function submitFunc() {

        let autorValue = document.getElementsByName('author')[0];
        let contentValue = document.getElementsByName('content')[0];

        let message = {
            author: autorValue.value,
            content: contentValue.value,
        }

        let postFetch = await fetch(url,
            {
                headers: {
                    'Content-Type': 'application/json'
                },
                method: 'Post',
                body: JSON.stringify(message)
            });
        refreshFunc();

    }


}

attachEvents();