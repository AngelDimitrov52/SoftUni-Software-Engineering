function printNumber(first, second, third) {
    let sum = first.length + second.length + third.length;
    console.log(sum);
    console.log(Math.floor(sum / 3));
}

printNumber('chocolate', 'ice cream', 'cake');