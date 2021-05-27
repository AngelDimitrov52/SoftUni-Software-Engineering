function process(array) {
    
    return array.filter((a, i) => i % 2 !== 0)
        .map(v => v * 2)
        .reverse()
        .join(' ');



}
console.log(process([10, 15, 20, 25]));
