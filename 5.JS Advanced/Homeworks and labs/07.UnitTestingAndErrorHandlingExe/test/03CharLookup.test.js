const lookupChar = require('../03CharLookup');
const { assert } = require('chai');

describe('Test lookupChar function', () => {
    it('Should return undefined when input is not correct', () => {
        assert.equal(lookupChar(true, 1), undefined);
        assert.equal(lookupChar(false, 1), undefined);
        assert.equal(lookupChar(undefined, 1), undefined);
        assert.equal(lookupChar(null, 1), undefined);
        assert.equal(lookupChar(23, 1), undefined);
        assert.equal(lookupChar("NaN", 1.1), undefined);
        assert.equal(lookupChar('test', '1'), undefined);
        assert.equal(lookupChar('test', null), undefined);
        assert.equal(lookupChar('test', undefined), undefined);
    });
    it('Should return Incorrect index when index is bigger than string length', () => {
        assert.equal(lookupChar('test', 12), "Incorrect index");
        assert.equal(lookupChar('test', 4), "Incorrect index");
        assert.equal(lookupChar('test', -4), "Incorrect index");
        assert.equal(lookupChar('test', -1), "Incorrect index");
        assert.equal(lookupChar('test', 5), "Incorrect index");
        assert.equal(lookupChar('', 5), "Incorrect index");
       assert.equal(lookupChar('', 0), "Incorrect index");
    });

    it('Should pass when input is correct', () => {
        assert.equal(lookupChar('test', 1), "e");
        assert.equal(lookupChar('test', 0), "t");
        assert.equal(lookupChar('test', 3), 't');
    });
});