function focused() {
    let divEleet = document.querySelectorAll('input');

    Array.from(divEleet).forEach(element => {

        element.addEventListener('focus', (e) => {
            element.parentElement.className = 'focused';
        });

        element.addEventListener('blur', (e) => {
            element.parentElement.className = ''
        });
    });



}