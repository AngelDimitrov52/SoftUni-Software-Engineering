function magic(array) {

    let flag = true;
    let current = array[0].reduce((a, b) => a + b, 0);

    array.forEach(element => {
        let row = array[0].reduce((a, b) => a + b, 0);
        if (current !== row) {
            flag = false;
        }
    });

    for (let col = 0; col < array.length; col++) {
        let sum = 0;
        for (let row = 0; row < array.length; row++) {
            sum += array[row][col];

        }
        if (sum !== current) {
            flag = false;
        }

    }

    console.log(flag);
}
magic([[4, 5, 6],
[6, 5, 4],
[5, 5, 5]]
);
magic([[11, 32, 45],
[21, 0, 1],
[21, 1, 1]]

);
magic([[1, 0, 0],
[0, 0, 1],
[0, 1, 0]]

);