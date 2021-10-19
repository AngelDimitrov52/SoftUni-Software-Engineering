const createCalculator = require('../07AddSubstract');
const { assert } = require('chai');

describe('Check createCalculator function', () => {
    let calc;
    beforeEach(function () {
        calc = createCalculator();
    })

    it('should return 0 for get()', () => {
        let result = calc.get();
        assert.equal(result, 0)
    });
    it('should return 5 for add()', () => {
        calc.add(3);
        calc.add(2);

        let result = calc.get();
        assert.equal(result, 5)
    });
    it('should return -5 for add()', () => {
        calc.add(-3);
        calc.add(-2);

        let result = calc.get();
        assert.equal(result, -5)
    });
    it('should return 5.5 - 1.1 for add()', () => {
        calc.add(5.5);
        calc.subtract(1.1);

        let result = calc.get();
        assert.equal(result, 5.5 - 1.1)
    });
    it('should return -5 for substract()', () => {
        calc.subtract(3);
        calc.subtract(2);

        let result = calc.get();
        assert.equal(result, -5)
    });

    it('should return 5 for substract()', () => {
        calc.subtract(-3);
        calc.subtract(-2);

        let result = calc.get();
        assert.equal(result, 5)
    });

    it('should return 8 for substract and add()', () => {
        calc.add(3);
        calc.add(2);
        calc.subtract(1);
        calc.add(4)

        let result = calc.get();
        assert.equal(result, 8)
    });
    it('should return Nan for add string()', () => {
        calc.add('text');

        let result = calc.get();
        assert.isNaN(result)
    });
    it('should return Nan for subtract string()', () => {
        calc.subtract('text');

        let result = calc.get();
        assert.isNaN(result)
    });
    it("should return 2 after add(10); subtract('7'); add('-2'); subtract(-1)", function () {
        calc.add(10);
        calc.subtract('7');
        calc.add('-2');
        calc.subtract(-1);
        let result = calc.get();
        assert.equal(result, 2)
    });
});