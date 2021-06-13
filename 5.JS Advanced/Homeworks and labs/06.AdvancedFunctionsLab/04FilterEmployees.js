function solve(dataArr, criteria) {
    let parsetArr = JSON.parse(dataArr);


    if (criteria != 'all') {
        let [critName, critValue] = criteria.split('-');
        parsetArr = parsetArr.filter(el => el[critName] === critValue);
    }

    for (let index = 0; index < parsetArr.length; index++) {

        console.log(`${index}. ${parsetArr[index].first_name} ${parsetArr[index].last_name} - ${parsetArr[index].email}`);
    }

}

solve([{"id": "1","first_name": "Kaylee","last_name": "Johnson","email": "k0@cnn.com","gender": "Female"}, {"id": "2","first_name": "Kizzee","last_name": "Johnson","email": "kjost1@forbes.com","gender": "Female"}, {"id": "3","first_name": "Evanne","last_name": "Maldin","email": "emaldin2@hostgator.com","gender": "Male"},{"id": "4","first_name": "Evanne","last_name": "Johnson","email": "ev2@hostgator.com","gender": "Male"}] last_name-Johnson);