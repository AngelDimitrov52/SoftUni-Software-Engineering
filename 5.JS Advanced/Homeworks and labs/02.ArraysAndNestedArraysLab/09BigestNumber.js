function big(array) {
    let maxNum = Number.NEGATIVE_INFINITY;
    for (let index = 0; index < array.length; index++) {

        let max = Math.max(...array[index]);
        if (maxNum < max) {
            maxNum = max;
        }
    }
    return maxNum;

}
//console.log(big([[20, 50, 10], [8, 33, 145]]));

//console.log(big([[3, 5, 7, 12],
//[-1, 4, 33, 2],
      //  [8, 3, 0, 4]]
      // ));
       console.log(big([[-3, -5, -7, -12] , [-5]]));
