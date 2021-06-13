function solution() {
    let result = '';
    return {
        append: function (str) { result += str },
        removeStart: function (n) { result = result.substring(n) },
        removeEnd: function (n) {  result = result.slice(0, -n) },
        print: function () { console.log(result) }
    }
};



let secondZeroTest = solution();

secondZeroTest.append('123');
secondZeroTest.append('45');
secondZeroTest.removeStart(2);
secondZeroTest.removeEnd(1);
secondZeroTest.print();

