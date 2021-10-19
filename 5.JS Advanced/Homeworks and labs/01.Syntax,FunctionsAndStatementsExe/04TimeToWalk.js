function calculate(steps, footprintLen, speed) {
    const dist = steps * footprintLen;
    let time = Math.round(dist / speed * 3.6);
    time += Math.floor(dist / 500) * 60;

    const seconds = time % 60;
    time -= seconds;
    time /= 60;

    const minutes = time % 60;
    time -= minutes;
    time /= 60;

    const hours = time;

    console.log(`${leftPad(hours, 2)}:${leftPad(minutes, 2)}:${leftPad(seconds, 2)}`);

    function leftPad(number, targetLength) {
        let output = number + '';
        while (output.length < targetLength) {
            output = '0' + output;
        }
        return output;
    }
}
calculate(4000, 0.60, 5);
calculate(2564, 0.70, 5.5);