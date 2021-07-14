function solve() {

    let stopInfoSpan = document.querySelector('.info');
    let departButton = document.getElementById('depart');
    let arriveButton = document.getElementById('arrive');

    function depart() {

        let nextStopId = 'depot';

        if (stopInfoSpan.getAttribute('next-stop-id') !== null) {
            nextStopId = stopInfoSpan.getAttribute('next-stop-id');
        }

        fetch(`http://localhost:3030/jsonstore/bus/schedule/${nextStopId}`)
            .then(responce => responce.json())
            .then(data => {
                stopInfoSpan.setAttribute('stop-name', data.name);
                stopInfoSpan.setAttribute('next-stop-id', data.next);
                stopInfoSpan.textContent = `Next stop ${data.name}`;
                departButton.disabled = true;
                arriveButton.disabled = false;
            })
            .catch(error => {
                stopInfoSpan.textContent = `Error`;
                departButton.disabled = true;
                arriveButton.disabled = true;
            })
    }

    function arrive() {
        let nameStop = stopInfoSpan.getAttribute('stop-name');
        stopInfoSpan.textContent = `Arriving at ${nameStop}`;
        departButton.disabled = false;
        arriveButton.disabled = true;
    }

    return {
        depart,
        arrive
    };
}

let result = solve();