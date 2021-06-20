function solve(array) {
    let products = {};
    let result = {}
    array.forEach(element => {
        let [product, quantity] = element.split(' => ')
        if (!products.hasOwnProperty(product)) {
            products[product] = 0;
        }
        products[product] += Number(quantity);

        let botle = Math.floor(products[product] / 1000);
        if (botle > 0) {
            result[product] = botle;
        }
    });
    for (const key in result) {
        console.log(`${key} => ${result[key]}`);
    }
}

solve(['Kiwi => 234',
    'Pear => 2345',
    'Watermelon => 3456',
    'Kiwi => 4567',
    'Pear => 5678',
    'Watermelon => 6789']


);