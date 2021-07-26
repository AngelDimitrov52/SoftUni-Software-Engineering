import { render } from "./../node_modules/lit-html/lit-html.js";
import { allTownsTemplate } from "./templates/templates.js";
import { towns } from "./towns.js";

let allTowns = towns.map(x => ({name: x}));

let divTowns = document.getElementById('towns');
render(allTownsTemplate(allTowns) , divTowns);

let searchButton = document.getElementById('btn');
searchButton.addEventListener('click', search);

function search() {
 
   allTowns.forEach(t => t.class = '');

   let searchText = document.getElementById('searchText').value;
   let matchTowns = allTowns.filter(t => t.name.includes(searchText));
   matchTowns.forEach(t => t.class = 'active');

   render(allTownsTemplate(allTowns), divTowns);

   
}
