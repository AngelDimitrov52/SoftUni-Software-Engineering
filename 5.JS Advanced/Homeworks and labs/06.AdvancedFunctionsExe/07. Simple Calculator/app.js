function calculator() {
    let resultObj = {};
    return {
        init: (selector1, selector2, resultSelector) => {
            resultObj.firstSelector = document.querySelector(selector1);
            resultObj.secondSelector = document.querySelector(selector2);
            resultObj.resultSelector = document.querySelector(resultSelector);
        },
        add: () => {
            let firstSelectorValue = Number(resultObj.firstSelector.value);
            let secondelectorValue = Number(resultObj.secondSelector.value);
            resultObj.resultSelector.value = firstSelectorValue + secondelectorValue;
        },
        subtract: () => {
            let firstSelectorValue = Number(resultObj.firstSelector.value);
            let secondelectorValue = Number(resultObj.secondSelector.value);
            resultObj.resultSelector.value = firstSelectorValue - secondelectorValue;
        },

    }
}
const calculate = calculator();
calculate.init('#num1', '#num2', '#result');




