function star(num) {
    if (num === undefined) {
        num = 5;
    }
    for (let row = 0; row < num; row++) {

        let result = '';
        for (let col = 0; col < num; col++) {
            result += '*' + ' ';

        }
        console.log(result);
    }

}

star();