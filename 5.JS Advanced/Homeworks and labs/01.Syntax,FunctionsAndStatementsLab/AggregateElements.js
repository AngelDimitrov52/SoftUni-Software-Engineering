function args (array){
    let sum = Number(0);
    for (let index = 0; index < array.length; index++) {
        sum += array[index]; 
    }
    console.log(sum);

    let sumInvers = Number(0);
    for (let index = 0; index < array.length; index++) {
        let num = 1 /array[index]
        sumInvers += num; 
    }
    console.log(sumInvers);

    let stringSum = '';
    for (let index = 0; index < array.length; index++) {
       
        stringSum += array[index]; 
    }
    console.log(stringSum);

}

args([1, 2, 3]);
args([2, 4, 8, 16]);