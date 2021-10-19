
function diagonalSum(array) {

    let firstDiagonal = 0;
    let secondDiagonal = 0;
    let firstIndex = 0;
    let secondIndex = array[0].length - 1;

    array.forEach(array => {
        firstDiagonal += array[firstIndex++];
        secondDiagonal += array[secondIndex--];

    });

    console.log(firstDiagonal + ' ' + secondDiagonal);


}
diagonalSum([[20, 40],
             [10, 60]]
);