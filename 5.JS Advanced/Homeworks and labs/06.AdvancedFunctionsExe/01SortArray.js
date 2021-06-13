function solve(array, command) {

    if (command === 'asc') {
        return ascSort(array);
    }
    else if (command === 'desc') {
        return desc(array);
    }


    function ascSort(array) {
        return array.sort((a, b) => a - b);
    }
    function desc(array) {
        return array.sort((a, b) => b - a);
    }

}

let sortArr = solve([14, 7, 17, 6, 8], 'asc');
console.log(sortArr);