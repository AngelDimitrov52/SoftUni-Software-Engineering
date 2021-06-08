function validate() {
    let regex = /[a-z]+@[a-z]+.[a-z]+/g;

    let inputElemet = document.getElementById('email');
    let inputText = inputElemet.value;

    inputElemet.addEventListener('change', (e) => {

        if (regex.test(e.target.value)) {
            e.target.className = '';
        }
        else {
            e.target.className = 'error';
        }
    });



}