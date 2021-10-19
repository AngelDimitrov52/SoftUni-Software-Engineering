function generateReport() {
    let thElemets = document.querySelectorAll('th');
    let tbodiElemets = document.querySelectorAll('tbody tr')
    let reultElemet = document.getElementById('output');

    let isThElementTrue = [];
    let result = [];

    Array.from(thElemets).forEach(th => {
        if (th.children[0].checked) {
            isThElementTrue.push(th.textContent.toLowerCase().trim())
        }
        else {
            isThElementTrue.push(false);
        }
    });

    Array.from(tbodiElemets).forEach(el => {
        let obj = {};
        Array.from(el.children).forEach((child, i) => {
            if (isThElementTrue[i]) {
                obj[isThElementTrue[i]] = child.textContent;
            }
        });
        result.push(obj)
    });

    reultElemet.textContent = JSON.stringify(result);

}

// let thElements = document.querySelectorAll('th');
// let trInTbodyElements = document.querySelectorAll('tbody tr');
// let outputElement = document.getElementById('output')
// let infoThElements = [];
// let result = [];
// Array.from(thElements).forEach(th => {
//     if (th.children[0].checked) {
//         infoThElements.push(th.textContent.toLowerCase().trim());
//     } else {
//         infoThElements.push(false);
//     }
// });
// Array.from(trInTbodyElements).forEach(trEl => {
//     let rowObj = {};
//     Array.from(trEl.children).forEach((el, i) => {
//         if (infoThElements[i]) {
//             let currCell = infoThElements[i];
//             rowObj[currCell] = el.textContent;
//         }
//     });
//     result.push(rowObj);
// });
// outputElement.textContent = JSON.stringify(result);