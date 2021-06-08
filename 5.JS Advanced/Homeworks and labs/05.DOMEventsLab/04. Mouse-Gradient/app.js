function attachGradientEvents() {
    let boxELement = document.getElementById('gradient-box');
    let result = document.getElementById('result');

    boxELement.addEventListener('mousemove', (e) => {
        let sum = Math.trunc(e.offsetX / e.target.clientWidth * 100);
        result.textContent = `${sum}%`;
    });

    boxELement.addEventListener('mouseout', (e) => {

        result.textContent = '';
    });

}

