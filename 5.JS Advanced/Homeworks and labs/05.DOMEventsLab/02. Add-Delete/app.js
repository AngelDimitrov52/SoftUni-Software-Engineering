function addItem() {
    let input = document.getElementById('newItemText').value;

    let liElement = document.createElement("li");
    liElement.textContent = input;

    let deleteButton = document.createElement('a');
    deleteButton.setAttribute('href', '#');
    deleteButton.textContent = '[Delete]';
    liElement.appendChild(deleteButton);

    document.getElementById("items").appendChild(liElement);

    deleteButton.addEventListener('click', (e) => {
        e.currentTarget.parentNode.remove();
    });

    document.getElementById('newItemText').value = '';
}
