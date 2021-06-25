const numberOperations = {
    powNumber: function (num) {
        return num * num;
    },
    numberChecker: function (input) {
        input = Number(input);

        if (isNaN(input)) {
            throw new Error('The input is not a number!');
        }

        if (input < 100) {
            return 'The number is lower than 100!';
        } else {
            return 'The number is greater or equal to 100!';
        }
    },
    sumArrays: function (array1, array2) {

        const longerArr = array1.length > array2.length ? array1 : array2;
        const rounds = array1.length < array2.length ? array1.length : array2.length;

        const resultArr = [];

        for (let i = 0; i < rounds; i++) {
            resultArr.push(array1[i] + array2[i]);
        }

        resultArr.push(...longerArr.slice(rounds));

        return resultArr
    }
}
console.log(numberOperations.sumArrays([2,5,7] , [3,8,2]));

const { assert } = require('chai');

describe("numberOperations", function () {
    describe("powNumber", function () {
        it("return correct number", function () {
            assert.equal(numberOperations.powNumber(2), 2 * 2);
            assert.equal(numberOperations.powNumber(2.2), 2.2 * 2.2);
            assert.equal(numberOperations.powNumber(16), 16 * 16);
            assert.equal(numberOperations.powNumber(-40), -40 * -40);
        });
    });

    describe("numberChecker", function () {
        it("throw when nunber is NaN", function () {
            assert.throws(() => numberOperations.numberChecker('hello'), 'The input is not a number!');
            assert.throws(() => numberOperations.numberChecker(undefined), 'The input is not a number!');
            assert.throws(() => numberOperations.numberChecker('1234jd'), 'The input is not a number!');
        });
        it("return when number is < 100", function () {
            assert.equal(numberOperations.numberChecker('16'), 'The number is lower than 100!');
            assert.equal(numberOperations.numberChecker('16.54'), 'The number is lower than 100!');
            assert.equal(numberOperations.numberChecker('99'), 'The number is lower than 100!');
            assert.equal(numberOperations.numberChecker('-1'), 'The number is lower than 100!');
            assert.equal(numberOperations.numberChecker(''), 'The number is lower than 100!');
        });
        it("return when number is > 100", function () {
            assert.equal(numberOperations.numberChecker('100'), 'The number is greater or equal to 100!');
            assert.equal(numberOperations.numberChecker('1000'), 'The number is greater or equal to 100!');
            assert.equal(numberOperations.numberChecker('130'), 'The number is greater or equal to 100!');
            assert.equal(numberOperations.numberChecker('150.45'), 'The number is greater or equal to 100!');

        });
    });
    describe("sumArrays", function () {
        it("throw when nunber is NaN", function () {
            assert.throws(() => numberOperations.numberChecker('hello'), 'The input is not a number!');
            assert.throws(() => numberOperations.numberChecker(undefined), 'The input is not a number!');
            assert.throws(() => numberOperations.numberChecker('1234jd'), 'The input is not a number!');
        });

    });

});