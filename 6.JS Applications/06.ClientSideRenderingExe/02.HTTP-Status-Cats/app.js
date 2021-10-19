import { render } from "./../node_modules/lit-html/lit-html.js";
import { cats } from "./catSeeder.js";
import { allCatsTemplate } from "./templates/templates.js";

let allCatsSection = document.getElementById('allCats');

function showMore(e) {
    let button = e.target;

    if (button.textContent === 'Show status code') {
        button.textContent = 'Hide status code';
    }
    else {
        button.textContent = 'Show status code';
    }

    let infoDiv = button.closest('.info');
    let statusDiv = infoDiv.querySelector('.status');

    if (statusDiv.classList.contains('hidden')) {

        statusDiv.classList.remove('hidden');
    }
    else {

        statusDiv.classList.add('hidden');
    }
}

render(allCatsTemplate(cats, showMore), allCatsSection);

