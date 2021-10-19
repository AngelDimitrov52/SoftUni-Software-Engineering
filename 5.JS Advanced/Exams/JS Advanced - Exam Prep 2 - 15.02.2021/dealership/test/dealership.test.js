let dealership = {
    newCarCost: function (oldCarModel, newCarPrice) {

        let discountForOldCar = {
            'Audi A4 B8': 15000,
            'Audi A6 4K': 20000,
            'Audi A8 D5': 25000,
            'Audi TT 8J': 14000,
        }

        if (discountForOldCar.hasOwnProperty(oldCarModel)) {
            let discount = discountForOldCar[oldCarModel];
            let finalPrice = newCarPrice - discount;
            return finalPrice;
        } else {
            return newCarPrice;
        }
    },

    carEquipment: function (extrasArr, indexArr) {
        let selectedExtras = [];
        indexArr.forEach(i => {
            selectedExtras.push(extrasArr[i])
        });

        return selectedExtras;
    },

    euroCategory: function (category) {
        if (category >= 4) {
            let price = this.newCarCost('Audi A4 B8', 30000);
            let total = price - (price * 0.05)
            return `We have added 5% discount to the final price: ${total}.`;
        } else {
            return 'Your euro category is low, so there is no discount from the final price!';
        }
    }
}

const { assert } = require('chai');

describe("dealership", function () {
    describe("newCarCost", function () {

        it("new price", function () {
            assert.equal(dealership.newCarCost('lada', 1000), 1000);
            assert.equal(dealership.newCarCost('Audi A6 4K34', 10000), 10000);
            assert.equal(dealership.newCarCost('lada', 1000.54), 1000.54);
        });
        it("old car price", function () {
            assert.equal(dealership.newCarCost('Audi A4 B8', 15000), 0);
            assert.equal(dealership.newCarCost('Audi A6 4K', 20000), 0);
            assert.equal(dealership.newCarCost('Audi A6 4K', 121213.353), 121213.353 - 20000);
            assert.equal(dealership.newCarCost('Audi A8 D5', 25000), 0);
            assert.equal(dealership.newCarCost('Audi TT 8J', 14000), 0);
            assert.equal(dealership.newCarCost('Audi TT 8J', 140000), 140000 - 14000);

        });
    });
    describe("carEquipment", function () {

        it("return selectedExtras array", function () {
            let arr1 = ['heated seats', 'sliding roof', 'sport rims', 'navigation']
            let arr2 = [0, 1, 2];
            let result = ['heated seats', 'sliding roof', 'sport rims'];
            assert.deepEqual(dealership.carEquipment(arr1, arr2), result)
        });
        it("return selectedExtras array again ", function () {
            let arr1 = ['heated seats', 'sliding roof', 'sport rims', 'navigation']
            let arr2 = [3, 1, 2];
            let result = ['navigation', 'sliding roof', 'sport rims'];
            assert.deepEqual(dealership.carEquipment(arr1, arr2), result)
        });

    });
    describe("euroCategory", function () {

        it("return low category", function () {
            assert.deepEqual(dealership.euroCategory(0), 'Your euro category is low, so there is no discount from the final price!')
            assert.deepEqual(dealership.euroCategory(-23), 'Your euro category is low, so there is no discount from the final price!')
            assert.deepEqual(dealership.euroCategory(2.15), 'Your euro category is low, so there is no discount from the final price!')
            assert.deepEqual(dealership.euroCategory(3), 'Your euro category is low, so there is no discount from the final price!')
        });
        it("return up category", function () {
            assert.deepEqual(dealership.euroCategory(4), `We have added 5% discount to the final price: 14250.`)
            assert.deepEqual(dealership.euroCategory(4.25), `We have added 5% discount to the final price: 14250.`)
            assert.deepEqual(dealership.euroCategory(44), `We have added 5% discount to the final price: 14250.`)
            assert.deepEqual(dealership.euroCategory(5), `We have added 5% discount to the final price: 14250.`)

        });


    });


});
