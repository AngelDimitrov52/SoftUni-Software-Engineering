const mathEnforcer = require('../04MathEnforcer');
const { assert } = require('chai');

describe('mathEnforcer', () => {
    describe('addFive', () => {
        it('should return undefined when input is not number', () => {
            assert.equal(mathEnforcer.addFive('3'), undefined);
            assert.equal(mathEnforcer.addFive('null'), undefined);
            assert.equal(mathEnforcer.addFive(null), undefined);
            assert.equal(mathEnforcer.addFive([3]), undefined);
            assert.equal(mathEnforcer.addFive(undefined), undefined);
            assert.equal(mathEnforcer.addFive(true), undefined);
            assert.equal(mathEnforcer.addFive(false), undefined);
        });
        it('should pass when input is number', () => {
            assert.equal(mathEnforcer.addFive(5), 10);
            assert.equal(mathEnforcer.addFive(2.5), 5 + 2.5);
            assert.equal(mathEnforcer.addFive(23452345320), 23452345325);
            assert.equal(mathEnforcer.addFive(0), 5);
            assert.equal(mathEnforcer.addFive(-6), -1);

        });

    });
    describe('subtractTen', () => {
        it('should return undefined when input is not number', () => {
            assert.equal(mathEnforcer.subtractTen('3'), undefined);
            assert.equal(mathEnforcer.subtractTen('null'), undefined);
            assert.equal(mathEnforcer.subtractTen(null), undefined);
            assert.equal(mathEnforcer.subtractTen([3]), undefined);
            assert.equal(mathEnforcer.subtractTen(undefined), undefined);
            assert.equal(mathEnforcer.subtractTen(true), undefined);
            assert.equal(mathEnforcer.subtractTen(false), undefined);
        });

        it('should pass when input is number', () => {
            assert.equal(mathEnforcer.subtractTen(5), -5);
            assert.equal(mathEnforcer.subtractTen(2.5), 2.5 - 10);
            assert.equal(mathEnforcer.subtractTen(0), - 10);
            assert.equal(mathEnforcer.subtractTen(-5), -15);
            assert.equal(mathEnforcer.subtractTen(100), 90);

        });
        describe('sum', () => {
            it('should return undefined when input is not number', () => {
                assert.equal(mathEnforcer.sum('3', 5), undefined);
                assert.equal(mathEnforcer.sum('null', 56), undefined);
                assert.equal(mathEnforcer.sum(null, 56), undefined);
                assert.equal(mathEnforcer.sum([3], 3), undefined);
                assert.equal(mathEnforcer.sum(undefined, 1), undefined);
                assert.equal(mathEnforcer.sum(true, 78), undefined);
                assert.equal(mathEnforcer.sum(false, 34), undefined);
                assert.equal(mathEnforcer.sum(34, '3'), undefined);
                assert.equal(mathEnforcer.sum(56, 'null'), undefined);
                assert.equal(mathEnforcer.sum(3, null), undefined);
                assert.equal(mathEnforcer.sum(3, [3]), undefined);
                assert.equal(mathEnforcer.sum(23, undefined), undefined);
                assert.equal(mathEnforcer.sum(78, true), undefined);
                assert.equal(mathEnforcer.sum(23, false), undefined);
                assert.equal(mathEnforcer.sum(undefined, undefined), undefined);
            });
            it('should pass when input is number', () => {
                assert.equal(mathEnforcer.sum(5, 5), 10);
                assert.equal(mathEnforcer.sum(-5, 5), 0);
                assert.equal(mathEnforcer.sum(-5, -5), -10);
                assert.equal(mathEnforcer.sum(5, -5), 0);
                assert.equal(mathEnforcer.sum(2.1, 5), 2.1 + 5);
                assert.equal(mathEnforcer.sum(2.1, 1.1), 2.1 + 1.1);
            });
        });

    });
});