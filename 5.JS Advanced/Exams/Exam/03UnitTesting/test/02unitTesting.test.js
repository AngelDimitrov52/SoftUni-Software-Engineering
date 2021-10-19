
const testNumbers = {
    sumNumbers: function (num1, num2) {
        let sum = 0;

        if (typeof (num1) !== 'number' || typeof (num2) !== 'number') {
            return undefined;
        } else {
            sum = (num1 + num2).toFixed(2);
            return sum
        }
    },
    numberChecker: function (input) {
        input = Number(input);

        if (isNaN(input)) {
            throw new Error('The input is not a number!');
        }

        if (input % 2 === 0) {
            return 'The number is even!';
        } else {
            return 'The number is odd!';
        }

    },
    averageSumArray: function (arr) {

        let arraySum = 0;

        for (let i = 0; i < arr.length; i++) {
            arraySum += arr[i]
        }

        return arraySum / arr.length
    }
};

const { assert } = require('chai');

describe("testNumbers", function () {

    describe("sumNumbers", function () {

        it("return undifined", function () {
            assert.equal(testNumbers.sumNumbers('hello', 5), undefined);
            assert.equal(testNumbers.sumNumbers('5', 5), undefined);
            assert.equal(testNumbers.sumNumbers(true, 5), undefined);
            assert.equal(testNumbers.sumNumbers(undefined, 5), undefined);
            assert.equal(testNumbers.sumNumbers(null, 5), undefined);
            assert.equal(testNumbers.sumNumbers('7.25', 5), undefined);
            assert.equal(testNumbers.sumNumbers(5, '.58'), undefined);
            assert.equal(testNumbers.sumNumbers(5, false), undefined);
            assert.equal(testNumbers.sumNumbers(5, undefined), undefined);
            assert.equal(testNumbers.sumNumbers(5, null), undefined);
            assert.equal(testNumbers.sumNumbers(5, 'hello'), undefined);
            assert.equal(testNumbers.sumNumbers('5', '5'), undefined);
            assert.equal(testNumbers.sumNumbers(null, null), undefined);
            assert.equal(testNumbers.sumNumbers(true, false), undefined);
        });
        it("return sum", function () {
            assert.equal(testNumbers.sumNumbers(5, 5), 10.00);
            assert.equal(testNumbers.sumNumbers(5.5, 5), (5.5 + 5).toFixed(2));
            assert.equal(testNumbers.sumNumbers(2.54, 6.48), (2.54 + 6.48).toFixed(2));
            assert.equal(testNumbers.sumNumbers(5, 0), 5.00);
        });
    });
    describe("numberChecker", function () {

        it("throw Error", function () {
            assert.throws(() => testNumbers.numberChecker('hello'), 'The input is not a number!');
            assert.throws(() => testNumbers.numberChecker(undefined), 'The input is not a number!');
            assert.throws(() => testNumbers.numberChecker('123jd'), 'The input is not a number!');
            assert.throws(() => testNumbers.numberChecker(NaN), 'The input is not a number!');

        });
        it("return 'The number is even!'", function () {
            assert.equal(testNumbers.numberChecker(2), 'The number is even!');
            assert.equal(testNumbers.numberChecker('2'), 'The number is even!');
            assert.equal(testNumbers.numberChecker(20), 'The number is even!');
            assert.equal(testNumbers.numberChecker(54345345656), 'The number is even!');
        });
        it("return 'The number is odd!'", function () {
            assert.equal(testNumbers.numberChecker(1), 'The number is odd!');
            assert.equal(testNumbers.numberChecker('1'), 'The number is odd!');
            assert.equal(testNumbers.numberChecker(11), 'The number is odd!');
            assert.equal(testNumbers.numberChecker(1453545), 'The number is odd!');
        });
    });
    describe("averageSumArray", function () {

        it("retur average", function () {
            assert.equal(testNumbers.averageSumArray([2,2,2]), 2);
            assert.equal(testNumbers.averageSumArray([2,2]), 2);
        

        });
    });
});


