function mathOperation(number1, number2, symbol) {
    let result;
    if (symbol === '+') {
        result = number1 + number2;
    }
    else if (symbol === '-') {
        result = number1 - number2;
    }
    else if (symbol === '*') {
        result = number1 * number2;
    }
    else if (symbol === '/') {
        result = number1 / number2;
    }
    else if (symbol === '%') {
        result = number1 % number2;
    }
    else if (symbol === '**') {
        result = number1 ** number2;
    }
    console.log(result);
}

mathOperation(5, 6, '+')
mathOperation(3, 5.5, '*')