function cook(...params) {

    let array = params;
    let num = Number(array[0]);
    for (let index = 1; index < array.length; index++) {
        if (array[index] === 'chop') {
            num /= 2;
        }
        else if (array[index] === 'dice') {
            num = Math.sqrt(num);
        }
        else if (array[index] === 'spice') {
            num++;
        }
        else if (array[index] === 'bake') {
            num *= 3;
        }
        else if (array[index] === 'fillet') {
            num *= 0.80;
        }
        console.log(num);
    }

}

cook('32', 'chop', 'chop', 'chop', 'chop', 'chop');
cook('9', 'dice', 'spice', 'chop', 'bake', 'fillet');