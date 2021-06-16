const isOddOrEven = require('../02EvenOrOdd');
const { assert } = require('chai');

describe('Test isOddOrEven function', () => {

    it('Should return undifined when imput is not correct', () => {
        assert.equal(isOddOrEven(23), undefined);
        assert.equal(isOddOrEven(null), undefined);
        assert.equal(isOddOrEven(undefined), undefined);
        assert.equal(isOddOrEven(NaN), undefined);
        assert.equal(isOddOrEven(true), undefined);
        assert.equal(isOddOrEven(), undefined);
        
    });
    it('Should return even when imput even number', () => {
        assert.equal(isOddOrEven('helloo'), 'even');
        assert.equal(isOddOrEven('dogs'), 'even');
        assert.equal(isOddOrEven('20'), 'even');
        assert.equal(isOddOrEven(''), 'even');
        
        
       
    });
    it('Should return odd when imput odd number', () => {

        assert.equal(isOddOrEven('hello'), 'odd');
        assert.equal(isOddOrEven('cat'), 'odd');
        assert.equal(isOddOrEven('1'), 'odd');
        assert.equal(isOddOrEven('111'), 'odd');
       
    });
});