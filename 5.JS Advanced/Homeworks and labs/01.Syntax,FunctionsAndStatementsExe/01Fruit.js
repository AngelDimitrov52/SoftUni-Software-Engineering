function fruint (fruit, kg , price){
    let lastKg = kg / 1000;
    let lastPrice = price * lastKg;

    console.log(`I need $${lastPrice.toFixed(2)} to buy ${lastKg.toFixed(2)} kilograms ${fruit}.`);
}

fruint('orange', 2500, 1.80);