function validate() {
    let emailElemet = document.getElementById('email');
    emailElemet.addEventListener('change', validate)

    function validate() {
        let reg = /^[a-z]+@[a-z]+\.[a-z]+$/;
        let ismach = reg.test(emailElemet.value);

        if (ismach) {
            emailElemet.className = '';
        } else {
            emailElemet.className = 'error';
        }

    }
}