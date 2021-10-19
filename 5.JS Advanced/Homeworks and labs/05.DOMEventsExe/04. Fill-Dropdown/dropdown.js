function addItem() {
    let textElement = document.getElementById('newItemText');
    let valueElement = document.getElementById('newItemValue');

    let optionElemet = document.createElement('option');
    optionElemet.textContent = textElement.value;
    optionElemet.value = valueElement.value;

    let selectElement = document.getElementById('menu');
    selectElement.appendChild(optionElemet);

    textElement.value = '';
    valueElement.value = '';
}