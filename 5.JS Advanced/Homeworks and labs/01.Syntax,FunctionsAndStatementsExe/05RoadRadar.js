function radar(speed, place) {
    let speedLim = 0;
    let mySpeed = Number(speed);

    if (place === 'motorway') {

        speedLim = 130;
    }
    else if (place === 'interstate') {

        speedLim = 90;
    }
    else if (place === 'city') {

        speedLim = 50;
    }
    else if (place === 'residential') {

        speedLim = 20;

    }

    if (mySpeed <= speedLim) {
        console.log(`Driving ${mySpeed} km/h in a ${speedLim} zone`);
    }
    else {
        let wrongSpeed = '';
        let sum = mySpeed - speedLim;
        if (sum <= 20) {
            wrongSpeed = 'speeding';
        }
        else if (sum <= 40) {
            wrongSpeed = 'excessive speeding';
        }
        else {
            wrongSpeed = 'reckless driving';
        }
        console.log(`The speed is ${sum} km/h faster than the allowed speed of ${speedLim} - ${wrongSpeed}`);
    }
}

radar(40, 'city');
radar(21, 'residential');
radar(120, 'interstate');
radar(200, 'motorway');