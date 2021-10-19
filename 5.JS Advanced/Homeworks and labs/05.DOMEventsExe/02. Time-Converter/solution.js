function attachEventsListeners() {

    let daysInput = document.getElementById('days');
    let hoursInput = document.getElementById('hours');
    let minInput = document.getElementById('minutes');
    let secInput = document.getElementById('seconds');

    let dayCoverButton = document.getElementById('daysBtn');
    let hoursCoverButton = document.getElementById('hoursBtn');
    let minCoverButton = document.getElementById('minutesBtn');
    let secCoverButton = document.getElementById('secondsBtn');

    let sec;
    secCoverButton.addEventListener('click', (e) => {
        sec = Number(secInput.value);
        calckInput(sec);
    });
    minCoverButton.addEventListener('click', (e) => {
        sec = Number(minInput.value) * 60;
        calckInput(sec);
    });
    hoursCoverButton.addEventListener('click', (e) => {
        sec = Number(hoursInput.value) * 60 * 60;
        calckInput(sec);
    });
    dayCoverButton.addEventListener('click', (e) => {
        sec = Number(daysInput.value) * 60 * 60 * 24;
        calckInput(sec);
    });

    function calckInput(sec) {
        daysInput.value = sec / 60 / 60 / 24;
        hoursInput.value = sec / 60 / 60;
        minInput.value = sec / 60;
        secInput.value = sec;

    }
}