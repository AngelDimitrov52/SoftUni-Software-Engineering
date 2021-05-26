function lastK(n, k) {

    let arry = [];
    arry[0] = 1;
    for (let index = 1; index < n; index++) {
        let value = 0;
        for (let i = 1; i <= k; i++) {
            let num = arry[index - i]
            if (num == undefined) {
                break;
            }
            value += num;
        }
        arry[index] = value;
    }
    return arry;
}
console.log(lastK(6, 3));
console.log(lastK(8, 2));