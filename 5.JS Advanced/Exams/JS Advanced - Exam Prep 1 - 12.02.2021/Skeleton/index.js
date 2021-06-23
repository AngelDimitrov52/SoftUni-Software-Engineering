function solve() {
    let addButtonElemet = document.querySelector('.actions button')
    let modules = {};

    addButtonElemet.addEventListener('click', addedLectur);

    function addedLectur(e) {
        e.preventDefault();
        let lectureName = document.getElementsByName('lecture-name')[0];
        let lectureDate = document.getElementsByName('lecture-date')[0];
        let lectureModule = document.getElementsByName('lecture-module')[0];


        if (!lectureName.value || !lectureDate.value || lectureModule.value == 'Select module') {
            return;
        }
        if (!modules[lectureModule.value]) {
            modules[lectureModule.value] = [];
        }

        let lecture = { name: lectureName.value, date: farmatDate(lectureDate.value) };

        modules[lectureModule.value].push(lecture);

        lectureName.value = '';
        lectureDate.value = '';
        lectureModule.value = 'Select module'

        createTrainings(modules);

    }
    function createTrainings(modules) {
        let trainingsElemet = document.querySelector('.modules')
        trainingsElemet.innerHTML = '';

        for (const moduleName in modules) {
            let moduleElemet = createModule(moduleName);
            let lecturListElemets = document.createElement('ul');

            let lectures = modules[moduleName];

            lectures.sort((a, b) => a.date.localeCompare(b.date));
            lectures.forEach(({ name, date }) => {
                let lecture = createLecture(name, date);
                lecturListElemets.appendChild(lecture);

                let buttonElemet = lecture.querySelector('button');
                buttonElemet.addEventListener('click', (e) => {
                    modules[moduleName] = modules[moduleName]
                        .filter(x => !(x.name == name && x.date == date));
                    if (modules[moduleName].length == 0) {
                        delete modules[moduleName];
                        e.currentTarget.parentNode.parentNode.parentNode.remove();
                    }
                    else {
                        e.currentTarget.parentNode.remove();
                    }
                });

            });

            moduleElemet.appendChild(lecturListElemets);
            trainingsElemet.appendChild(moduleElemet);
        }


    }
    function createLecture(name, date) {
        let button = document.createElement('button');
        button.classList.add('red');
        button.textContent = 'Del';

        let h4 = document.createElement('h4');
        h4.textContent = `${name} - ${date}`

        let liElemet = document.createElement('li');
        liElemet.classList.add('flex');
        liElemet.appendChild(h4);
        liElemet.appendChild(button);

        return liElemet;
    }

    function createModule(moduleName) {
        let divElemet = document.createElement('div');
        divElemet.classList.add('module');

        let h3 = document.createElement('h3');
        h3.textContent = `${moduleName.toUpperCase()}-MODULE`;

        divElemet.appendChild(h3);

        return divElemet;

    }


    function farmatDate(date) {
        let result = '';
        let [currentDate, time] = date.split('T');
        let [day, mount, year] = currentDate.split('-');
        result = `${day}/${mount}/${year} - ${time}`;
        return result;
    }
};