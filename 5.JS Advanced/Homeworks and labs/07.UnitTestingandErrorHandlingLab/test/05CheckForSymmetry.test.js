const isSymmetric = require('../05CheckForSymmetry');
const { assert } = require('chai');

describe('Test isSymmetric functions', () => {
    it('Should pass when array is symetric', () => {
        let input = [1, 2, 3, 2, 1];
        let expectedResult = true;

        let result = isSymmetric(input);
        assert.equal(expectedResult, result);
    });
    it('Should fail when array is not symetric', () => {
        let input = [1, 2, 3, 4, 1];
        let expectedResult = false;

        let result = isSymmetric(input);
        assert.equal(expectedResult, result);
    });
    it('Should fail when array is not in correctFormat', () => {
        let input = [1, '2', 3, 4, 1];
        let expectedResult = false;

        let result = isSymmetric(input);
        assert.equal(expectedResult, result);
    });
    it('Should fail when input is invalid', () => {

        assert.equal(isSymmetric(null), false);
        assert.equal(isSymmetric({}), false);
        assert.equal(isSymmetric(undefined), false);
        assert.equal(isSymmetric('pesho'), false);
        assert.equal(isSymmetric(0), false);
        assert.equal(isSymmetric(true), false);
        assert.equal(isSymmetric([1 , '1']), false);
    });
    it('Should pass when emptyArr is providet', () => {

        let emptyArr = [];
        let expectedResult = true;
        let result = isSymmetric(emptyArr);

        assert.equal(expectedResult , result);
    });

});