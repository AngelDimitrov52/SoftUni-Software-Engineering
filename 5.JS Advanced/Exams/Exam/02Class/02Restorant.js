class Restaurant {
    constructor(butget) {
        this.budgetMoney = Number(butget);
        this.menu = {};
        this.stockProducts = {};
        this.history = [];
    }
    loadProducts(arrayProducts) {

        arrayProducts.forEach(procuct => {
            let [productName, productQuantity, productTotalPrice] = procuct.split(' ')

            if (this.budgetMoney >= Number(productTotalPrice)) {
                this.budgetMoney -= Number(productTotalPrice);

                if (!this.stockProducts.hasOwnProperty(productName)) {
                    this.stockProducts[productName] = 0;
                }
                this.stockProducts[productName] += Number(productQuantity);

                this.history.push(`Successfully loaded ${productQuantity} ${productName}`.trim());
            }
            else {
                this.history.push(`There was not enough money to load ${productQuantity} ${productName}`.trim());
            }
        });
        return this.history.join('\n').trim();
    }
    addToMenu(meal, neededArr, price) {
        if (this.menu.hasOwnProperty(meal)) {
            return `The ${meal} is already in the our menu, try something different.`.trim();
        }
        else {
            let productArr = []
            neededArr.forEach(element => {
                let [name, count] = element.split(' ');
                productArr.push({
                    name,
                    count: Number(count)
                })
            });
            this.menu[meal] = {
                products: productArr,
                price: price,
            }
            let countMeal = Object.keys(this.menu).length;
            if (countMeal == 1) {
                return `Great idea! Now with the ${meal} we have 1 meal in the menu, other ideas?`.trim();
            }
            else {
                return `Great idea! Now with the ${meal} we have ${countMeal} meals in the menu, other ideas?`.trim();
            }
        }

    }
    showTheMenu() {
        let result = [];
        if (Object.keys(this.menu).length == 0) {
            return "Our menu is not ready yet, please come later...".trim();
        }
        else {
            for (const key in this.menu) {
                result.push(`${key} - $ ${this.menu[key].price}`.trim())
            }
            return result.join('\n').trim();
        }
    }
    makeTheOrder(meal) {
        if (!this.menu.hasOwnProperty(meal)) {
            return `There is not ${meal} yet in our menu, do you want to order something else?`.trim();
        }
        else {
            let mealProduct = this.menu[meal].products;
            let flag = true;
            mealProduct.forEach(element => {
                let isIn = this.stockProducts.hasOwnProperty(element.name);
                if (!isIn) {
                    flag = false;
                }

                if (this.stockProducts[element.name] < element.count) {
                    flag = false;
                }
            });
            if (flag == false) {
                return `For the time being, we cannot complete your order (${meal}), we are very sorry...`.trim();
            }
            mealProduct.forEach(element => {
                let stocProd = this.stockProducts[element.name];
                stocProd -= element.count;
            });
            return `Your order (${meal}) will be completed in the next 30 minutes and will cost you ${this.menu[meal].price}.`.trim();
        }

    }
}
let kitchen = new Restaurant(1000);
kitchen.loadProducts(['Yogurt 30 3', 'Honey 50 4', 'Strawberries 20 10', 'Banana 5 1']);
kitchen.addToMenu('frozenYogurt', ['uogurt 1', 'Honey 1', 'Banana 1', 'Strawberries 10'], 9.99);
console.log(kitchen.makeTheOrder('frozenYogurt'));



