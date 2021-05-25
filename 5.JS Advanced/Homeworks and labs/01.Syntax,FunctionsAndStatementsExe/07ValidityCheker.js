

function valid(x1, y1, x2, y2) {

    function calucateDistance(x1, y1, x2, y2) {
        const distX = x1 - x2;
        const distY = y1 - y2;
        return Math.sqrt(distX ** 2 + distY ** 2);
    }

    let sum1 = calucateDistance(x1, y1, 0, 0)
    let sum2 = calucateDistance(0, 0, x2, y2)
    let sum3 = calucateDistance(x1, y1, x2, y2)

    let sum1Print = `{${x1}, ${y1}} to {${0}, ${0}} is `;
    let sum2Print = `{${x2}, ${y2}} to {${0}, ${0}} is `;
    let sum3Print = `{${x1}, ${y1}} to {${x2}, ${y2}} is `;

    if (Number.isInteger(sum1)) {
        sum1Print += 'valid';
    }
    else {
        sum1Print += 'invalid';
    }
    if (Number.isInteger(sum2)) {
        sum2Print += 'valid';
    }
    else {
        sum2Print += 'invalid';
    }
    if (Number.isInteger(sum3)) {
        sum3Print += 'valid';
    }
    else {
        sum3Print += 'invalid';
    }

    console.log(sum1Print);
    console.log(sum2Print);
    console.log(sum3Print);

}

valid(3, 0, 0, 4);
valid(2, 1, 1, 1);