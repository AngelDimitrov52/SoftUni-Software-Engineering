function sum(array) {
    let firt = Number(array.shift());
    let last = Number(array.pop());
    let sum = firt + last;

    return sum;

}

console.log(sum(['20', '30', '40']));
console.log(sum(['5', '10']));