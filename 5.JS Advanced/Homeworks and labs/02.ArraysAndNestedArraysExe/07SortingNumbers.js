function sortNumbers(array) {
    let sortArray = array.map(x => Number(x)).sort((a, b) => a - b);

    let fristIndex = 0;
    let lastIndex = sortArray.length - 1;
    let sortingNumbersArray = [];

    while (lastIndex >= fristIndex) {

        sortingNumbersArray.push(sortArray[fristIndex]);

        if (lastIndex === fristIndex ) {
            break;
        }
        sortingNumbersArray.push(sortArray[lastIndex]);

        fristIndex++;
        lastIndex--;
    }

    return sortingNumbersArray;
}
console.log(sortNumbers(['1', 65, 3, 52, 48, 63, 31, -3, 18, 56 , 100]));