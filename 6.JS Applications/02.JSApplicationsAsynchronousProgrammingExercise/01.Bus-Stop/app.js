function getInfo() {
    let inputElement = document.getElementById('stopId');

    let url = `http://localhost:3030/jsonstore/bus/businfo/${inputElement.value}`
    inputElement.value = '';

    fetch(url)
        .then(data => data.json())
        .then(stopInfo => {

            let divStopName = document.getElementById('stopName');
            divStopName.textContent = stopInfo.name;

            let bussesListElemet = document.getElementById('buses');
            let allLi = bussesListElemet.querySelectorAll('li');
            allLi.forEach(li => {
                li.remove();
            });


            Object.keys(stopInfo.buses).forEach(key => {
                let liElemet = document.createElement('li');
                liElemet.textContent = `Bus ${key} arrives in ${stopInfo.buses[key]}`
                bussesListElemet.appendChild(liElemet);
            });
        })
        .catch(error => {
            let divStopName = document.getElementById('stopName');
            divStopName.textContent = "Error";
        })
}