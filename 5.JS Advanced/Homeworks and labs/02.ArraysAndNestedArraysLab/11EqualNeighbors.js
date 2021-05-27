function equal(array) {

    let counter = 0;
    for (let row = 0; row < array.length - 1; row++) {

        let len = Number(array[row].length);
        for (let col = 0; col < len; col++) {

            let element = array[row][col];
            let rowwPlus = row + 1;
            let secondElement = array[rowwPlus][col];

            if (element === secondElement) {
                counter++;
            }
        }

    }
    for (let row = 0; row < array.length; row++) {

        let len = Number(array[row].length -1 );
        for (let col = 0; col < len; col++) {

            let element = array[row][col];
            let colPlus = col + 1;
            let secondElement = array[row][colPlus];

            if (element === secondElement) {
                counter++;
            }
        }

    }
    console.log(counter);
}
equal([['2', '3', '4', '7', '0'],
['4', '0', '5', '3', '4'],
['2', '3', '5', '4', '2'],
['9', '8', '7', '5', '4']]
);
equal([['test', 'yes', 'yo', 'ho'],
['well', 'done', 'yo', '6'],
['not', 'done', 'yet', '5']]
);
