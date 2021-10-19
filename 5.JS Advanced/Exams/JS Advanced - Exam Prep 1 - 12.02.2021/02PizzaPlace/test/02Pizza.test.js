let pizzUni = {
   makeAnOrder: function (obj) {

      if (!obj.orderedPizza) {
         throw new Error('You must orr at least 1 Pizza to finish the order.');
      } else {
         let result = `You just ordered ${obj.orderedPizza}`
         if (obj.orderedDrink) {
            result += ` and ${obj.orderedDrink}.`
         }
         return result;
      }
   },

   getRemainingWork: function (statusArr) {

      const remainingArr = statusArr.filter(s => s.status != 'ready');

      if (remainingArr.length > 0) {

         let pizzaNames = remainingArr.map(p => p.pizzaName).join(', ')
         let pizzasLeft = `The following pizzas are still preparing: ${pizzaNames}.`

         return pizzasLeft;
      } else {
         return 'All orders are complete!'
      }

   },

   orderType: function (totalSum, typeOfOrder) {
      if (typeOfOrder === 'Carry Out') {
         totalSum -= totalSum * 0.1;

         return totalSum;
      } else if (typeOfOrder === 'Delivery') {

         return totalSum;
      }
   }
}

const { assert } = require('chai');

describe("pizzUni", function () {
   describe("makeAnOrder", function () {

      it(" should throw when obj have no orderedPizza", function () {
         let obj = { order: 'pizza' }
         assert.throws(() => pizzUni.makeAnOrder(obj));
      });
      it(" should throw when obj have no orderedPizza", function () {
         let obj = {}
         assert.throws(() => pizzUni.makeAnOrder(obj));
      });
      it(" should return result when obj have orderedPizza", function () {
         let obj = { orderedPizza: 'pele' }
         assert.equal(pizzUni.makeAnOrder(obj), `You just ordered ${obj.orderedPizza}`);
      });
      it(" should return result when obj have orderedPizza", function () {
         let obj = { orderedPizza: 'pele', orderedDrink: undefined }
         assert.equal(pizzUni.makeAnOrder(obj), `You just ordered ${obj.orderedPizza}`);
      });
      it(" should return result when obj have orderedPizza and dring", function () {
         let obj = { orderedPizza: 'pele', orderedDrink: 'water' }
         assert.equal(pizzUni.makeAnOrder(obj), `You just ordered ${obj.orderedPizza}` + ` and ${obj.orderedDrink}.`);
      });
   });

   describe("getRemainingWork", function () {

      it(" should return result when all pizza is ready", function () {
         let arr = [{ pizzaName: 'pele', status: 'ready' }];
         assert.equal(pizzUni.getRemainingWork(arr), 'All orders are complete!');
      });
      it(" should return result when all pizza is ready", function () {
         let arr = [{ pizzaName: 'pele', status: 'ready' },
         { pizzaName: 'hola', status: 'ready' },
         { pizzaName: 'git', status: 'ready' }];
         assert.equal(pizzUni.getRemainingWork(arr), 'All orders are complete!');
      });
      it(" should return result when not all pizza is ready", function () {
         let arr = [{ pizzaName: 'pele', status: 'ready' },
         { pizzaName: 'hola', status: 'preparing' },
         { pizzaName: 'git', status: 'ready' }];
         assert.equal(pizzUni.getRemainingWork(arr), `The following pizzas are still preparing: hola.`);
      });
      it(" should return result when not all pizza is ready", function () {
         let arr = [{ pizzaName: 'pele', status: 'ready' },
         { pizzaName: 'hola', status: 'preparing' },
         { pizzaName: 'git', status: 'preparing' }];
         assert.equal(pizzUni.getRemainingWork(arr), `The following pizzas are still preparing: hola, git.`);
      });

   });
   describe("orderType", function () {

      it(" should return result when no discount", function () {
         assert.equal(pizzUni.orderType(100, 'Delivery'), 100);
         assert.equal(pizzUni.orderType(46, 'Delivery'), 46);
         assert.equal(pizzUni.orderType(3.14, 'Delivery'), 3.14);
      });
      it(" should return result when have discount", function () {
         assert.equal(pizzUni.orderType(100, 'Carry Out'), 100 * 0.9);
         assert.equal(pizzUni.orderType(46, 'Carry Out'), 46 * 0.9);
         assert.equal(pizzUni.orderType(3.14, 'Carry Out'), 3.14 * 0.9);
      });


   });
});
