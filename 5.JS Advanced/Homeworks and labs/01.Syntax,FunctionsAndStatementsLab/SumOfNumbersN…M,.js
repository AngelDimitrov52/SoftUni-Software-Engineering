function sum(n, m) {

    let totalSum = 0;
    let num1 = Number(n);
    let num2 = Number(m);

    for (let index = num1; index <= num2; index++) {

        totalSum += index;
    }
    console.log(totalSum);
}

sum('1', '5');
sum('-8', '20');