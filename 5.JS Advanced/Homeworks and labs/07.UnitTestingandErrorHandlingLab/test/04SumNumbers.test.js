const { assert } = require('chai');
const sum = require('../04SumNumbers');

describe('Check sum function', () => {

    it('Should work when input i s corectli', () => {
let arr = [1,2,3,4,5];
let expectedResult = 15;
let result = sum(arr);
assert.equal(expectedResult , result);
    });

    it('Should work when input i s corectli', () => {
        let arr = [1,2,3,4,5];
        let expectedResult = 15;
        let result = sum(arr);
        assert.equal(expectedResult , result);
            });


})