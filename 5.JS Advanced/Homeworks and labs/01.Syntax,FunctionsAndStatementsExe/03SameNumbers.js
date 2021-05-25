function same(num) {
    let flag = true;;
    let numToString = String(num);
    let sum = 0;

    for (let index = 0; index < numToString.length; index++) {

        if (index != numToString.length - 1) {

            if (numToString[index] !== numToString[index + 1]) {
                flag = false;
            }
        }
        sum += Number(numToString[index]);
    }
    console.log(flag);
    console.log(sum);

}

same(2222222);
same(1234);