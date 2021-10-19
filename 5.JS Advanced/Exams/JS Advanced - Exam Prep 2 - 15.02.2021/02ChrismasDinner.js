class ChristmasDinner {
    constructor(number) {
        if (number < 0) {
            throw new Error("The budget cannot be a negative number");
        }
        this.budget = number
        this.dishes = [];
        this.products = [];
        this.guests = {};
    }
    shopping(product) {
        let [productType, price] = product;
        if (Number(price) > this.budget) {
            throw new Error("Not enough money to buy this product");
        }
        this.budget -= Number(price);
        this.products.push(productType);
        return `You have successfully bought ${productType}!`
    }
    recipes(recipe) {
        let productListArr = recipe.productsList;
        productListArr.forEach(productLis => {
            let isTrue = this.products.some(p => p === productLis);
            if (!isTrue) {
                throw new Error("We do not have this product")
            }
        });
        this.dishes.push(recipe);
        return `${recipe.recipeName} has been successfully cooked!`
    }
    inviteGuests(name, dish) {
        let isTrueDish = this.dishes.some(p => p.recipeName === dish);
        if (isTrueDish === false) {
            throw new Error("We do not have this dish");
        }
        if (this.guests[name]) {
            throw new Error("This guest has already been invited");
        }
        this.guests[name] = dish;
        return `You have successfully invited ${name}!`
    }
    showAttendance() {
        let result = '';
        for (const key in this.guests) {
            let findProduct = this.dishes.find(p => p.recipeName === this.guests[key])

            result += `${key} will eat ${this.guests[key]}, which consists of ${findProduct.productsList.join(', ')}\n`
        }
        return result.trim();
    }
}
let dinner = new ChristmasDinner(300);

dinner.shopping(['Salt', 1]);
dinner.shopping(['Beans', 3]);
dinner.shopping(['Cabbage', 4]);
dinner.shopping(['Rice', 2]);
dinner.shopping(['Savory', 1]);
dinner.shopping(['Peppers', 1]);
dinner.shopping(['Fruits', 40]);
dinner.shopping(['Honey', 10]);

dinner.recipes({
    recipeName: 'Oshav',
    productsList: ['Fruits', 'Honey']
});
dinner.recipes({
    recipeName: 'Folded cabbage leaves filled with rice',
    productsList: ['Cabbage', 'Rice', 'Salt', 'Savory']
});
dinner.recipes({
    recipeName: 'Peppers filled with beans',
    productsList: ['Beans', 'Peppers', 'Salt']
});


dinner.inviteGuests('Ivan', 'Oshav');
dinner.inviteGuests('Petar', 'Folded cabbage leaves filled with rice');
dinner.inviteGuests('Georgi', 'Peppers filled with beans');

console.log(dinner.showAttendance());
