function subSum(arr, starIndex, endIndex) {
    if (Array.isArray(arr) === false) {
        return NaN;
    }

    if (starIndex < 0) {
        starIndex = 0;
    }

    if (endIndex > arr.length - 1) {
        endIndex = arr.length - 1;
    }

    let sliveArr = arr.slice(starIndex, endIndex + 1);
    let result = sliveArr.reduce((acc, el) => acc + Number(el), 0)

    return result;
}

subSum([10, 20, 30, 40, 50, 60], 3, 300);