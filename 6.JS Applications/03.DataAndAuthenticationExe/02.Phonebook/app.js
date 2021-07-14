function attachEvents() {
    
    let loadButton = document.getElementById('btnLoad');
    loadButton.addEventListener('click', loadAllPhones);
    let phonebookUlElemet = document.getElementById('phonebook');

    let createButton = document.getElementById('btnCreate');
    createButton.addEventListener('click', createPhone)

    async function loadAllPhones() {

        let allLi = phonebookUlElemet.querySelectorAll('li');
        allLi.forEach(element => {
            element.remove();
        });

        let url = 'http://localhost:3030/jsonstore/phonebook';
        let getPhones = await fetch(url);
        let phones = await getPhones.json();

        for (const key in phones) {
            let phoneLi = document.createElement('li');
            phoneLi.textContent = `${phones[key].person}: ${phones[key].phone}`;
            phoneLi.setAttribute('id', key);

            let deleteButton = document.createElement('button');
            deleteButton.textContent = 'Delete';
            deleteButton.addEventListener('click', deleteFunc)

            phoneLi.appendChild(deleteButton);

            phonebookUlElemet.appendChild(phoneLi);
        }
    }
    async function deleteFunc(e) {
        let li = e.target.parentElement;
        let id = li.id;

        let fetchPost = await fetch(`http://localhost:3030/jsonstore/phonebook/${id}`,
            {
                method: "Delete",
            });
        li.remove();
    }

    async function createPhone() {

        let personElemet = document.getElementById('person');
        let phoneElemet = document.getElementById('phone');

        if (personElemet.value.trim() == '' || phoneElemet.value.trim() == '') {
            return;
        }

        let newPhone = {
            person: personElemet.value,
            phone: phoneElemet.value
        }
        personElemet.value = '';
        phoneElemet.value = '';

        let fetchPost = await fetch('http://localhost:3030/jsonstore/phonebook',
            {
                headers: {
                    'Content-Type': 'application/json'
                },
                method: "Post",
                body: JSON.stringify(newPhone)
            });
        loadAllPhones();
    }
}
attachEvents();