function lowPrice(array) {
    let result = [];
    for (let index = 0; index < array.length; index++) {
        let [townName, productName, productPrice] = array[index].split(' | ');

        productPrice = Number(productPrice);

        let elIndex = result.findIndex(x => x.productName === productName);
        elIndex = Number(elIndex);

        if (elIndex !== -1) {
            if (result[elIndex].productPrice > productPrice) {
                result[elIndex].productPrice = productPrice;
                result[elIndex].townName = townName;
            }
        } else {
            result.push({ townName, productName, productPrice });
        }
    }

    result.forEach(element => {
        console.log(`${element.productName} -> ${element.productPrice} (${element.townName})`);
    });

}
lowPrice(['Sample Town | Sample Product | 1000',
    'Sample Town | Orange | 2',
    'Sample Town | Peach | 1',
    'Sofia | Orange | 3',
    'Sofia | Peach | 2',
    'New York | Sample Product | 1000.1',
    'New York | Burger | 10']

);