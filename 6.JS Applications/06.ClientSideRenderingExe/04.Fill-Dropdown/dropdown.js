import { render } from "./../node_modules/lit-html/lit-html.js";
import { allOptionTeplate } from "./template.js";


let menuSelectElemet = document.getElementById('menu');

let addOptionForm = document.getElementById('add-option-form');
addOptionForm.addEventListener('submit', addItem);

loadOptions();

let optionArr = [];

async function loadOptions() {
    let optionResponce = await fetch('http://localhost:3030/jsonstore/advanced/dropdown');
    let option = await optionResponce.json();
    optionArr = Object.values(option);
    render(allOptionTeplate(optionArr), menuSelectElemet);
    
}



async function addItem(e) {
    e.preventDefault();
    let form = e.target;
    let formData = new FormData(form);

    let newOption = {
        text: formData.get('text')
    }

    let createResponse = await fetch('http://localhost:3030/jsonstore/advanced/dropdown', {
        headers: { 'Content-Type': 'application/json' },
        method: 'Post',
        body: JSON.stringify(newOption)
    });

    if (createResponse.ok) {
        let createdOption = await createResponse.json();
        optionArr.push(createdOption);
        render(allOptionTeplate(optionArr), menuSelectElemet);
    }
}