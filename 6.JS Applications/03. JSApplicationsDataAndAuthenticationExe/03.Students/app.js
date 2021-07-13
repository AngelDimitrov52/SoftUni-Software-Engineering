let firstNameElemet = document.getElementsByName('firstName')[0];
let lastNameElemet = document.getElementsByName('lastName')[0];
let facultyNumberElemet = document.getElementsByName('facultyNumber')[0];
let gradeElemet = document.getElementsByName('grade')[0];

let formElemet = document.getElementById('form');
formElemet.addEventListener('submit', submitElemets);

let tBody = document.querySelector('#results tbody')
console.log(tBody);

async function submitElemets(e) {
    e.preventDefault();
    tBody.querySelectorAll('tr').forEach(element => {
        element.remove();
    });
    let form = e.currentTarget;
    let formData = new FormData(form);

    let firstName = formData.get('firstName');
    let lastName = formData.get('lastName');
    let facultyNumber = formData.get('facultyNumber');
    let grade = formData.get('grade');

    if (firstName.trim() == '' || lastName.trim() == '' || Number(facultyNumber) == NaN || Number(grade) == 0) {
        return;
    }
    let numberGrade = Number(grade).toFixed(2);
    let student = {
        firstName: firstName,
        lastName: lastName,
        facultyNumber: facultyNumber,
        grade: numberGrade
    }

    firstNameElemet.value = '';
    lastNameElemet.value = '';
    facultyNumberElemet.value = '';
    gradeElemet.value = '';

    let postFetch = await fetch('http://localhost:3030/jsonstore/collections/students', {

        headers: {
            'Content-Type': 'application/json'
        },
        method: "Post",
        body: JSON.stringify(student)
    });

    let get = await fetch('http://localhost:3030/jsonstore/collections/students');
    let data = await get.json();
    for (const key in data) {
    
        let tr = document.createElement('tr');

        let firstNameTd = document.createElement('td');
        firstNameTd.textContent = data[key].firstName;
        let lastNameTd = document.createElement('td');
        lastNameTd.textContent = data[key].lastName;
        let facultyNumberTd = document.createElement('td');
        facultyNumberTd.textContent = data[key].facultyNumber;
        let gradeTd = document.createElement('td');
        gradeTd.textContent = data[key].grade;

        tr.appendChild(firstNameTd);
        tr.appendChild(lastNameTd);
        tr.appendChild(facultyNumberTd);
        tr.appendChild(gradeTd);

        tBody.appendChild(tr);
    }

}