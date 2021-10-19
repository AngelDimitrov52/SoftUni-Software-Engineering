import { render } from "./../node_modules/lit-html/lit-html.js";
import { allTownTemplate } from "./templates.js";

let formElement = document.querySelector('.content');
formElement.addEventListener('submit', showAllTawns);

let div = document.getElementById('root');

function showAllTawns(e) {
    e.preventDefault();
    console.log(e);

    let form = e.target;
    let formData = new FormData(form);

    let stringTowns = formData.get('towns');
    let townArr = stringTowns.split(', ');

    render(allTownTemplate(townArr), div);
}

