function sortHalf(array) {
    array.sort((a, b) => a - b);

    let arraylength = Math.floor(array.length / 2);
    array.splice(0, arraylength)

    return array;
}

sortHalf([4, 7, 2, 5]);
sortHalf([3, 19, 14, 7, 2, 19, 6]);