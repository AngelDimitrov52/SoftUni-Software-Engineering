import { render } from './../node_modules/lit-html/lit-html.js';
import { allStudentsTemplate } from './template/studentTemplates.js';

 let btn = document.querySelector('#searchBtn');
 btn.addEventListener('click', onClick);
let table = document.querySelector('.container tbody');

let students = [];

loadStudents();

async function loadStudents() {
   let studentsResponse = await fetch('http://localhost:3030/jsonstore/advanced/table');
   let studentsObj = await studentsResponse.json();
   students = Object.values(studentsObj).map(x => ({
      name: `${x.firstName} ${x.lastName}`,
      course: x.course,
      email: x.email
   }));

   render(allStudentsTemplate(students), table);
}

function onClick() {
   let searchInput = document.getElementById('searchField');
   let searchText = searchInput.value.toLowerCase();

   let allStudents = students.map(s => Object.assign({}, s));
   let matchedStudents = allStudents
      .filter(s => Object.values(s).some(val => {
         return val.toLowerCase().includes(searchText)
      }));
   matchedStudents.forEach(s => s.class = 'select');

   searchInput.value = '';
   render(allStudentsTemplate(allStudents), table);
}