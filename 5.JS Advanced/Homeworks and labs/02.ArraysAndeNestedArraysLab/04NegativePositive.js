function solve(array) {
    let sortArray = [];

    for (let index = 0; index < array.length; index++) {
        let num = Number(array[index]);

        if (num < 0) {
            sortArray.unshift(num);
        }
        else {
            sortArray.push(num);
        }
    }

    for (const key of sortArray) {
       console.log(key);
    }
}

solve([7, -2, 8, 9]);
solve([3, -2, 0, -1]);