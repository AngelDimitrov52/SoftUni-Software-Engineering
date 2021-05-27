function evenPosition(nummbers) {
    let evenArr = [];
for (let index = 0; index < nummbers.length; index+=2) {
    evenArr.push(nummbers[index])
    
}
console.log(evenArr.join(' '));
    
}
evenPosition(['20', '30', '40', '50', '60'])