function listSort(array) {
    array.sort((function (a, b) {
        a = a.toUpperCase();
        b = b.toUpperCase();
        if (a == b) return 0;
        if (a > b) return 1;
        return -1;
    }));
    for (let index = 1; index <= array.length; index++) {
        console.log(index + '.' + array[index - 1]);

    }
}
listSort(["John", "bob", "Christina", "Ema"]);