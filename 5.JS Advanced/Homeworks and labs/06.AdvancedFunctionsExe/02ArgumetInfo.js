function solve(...params) {
    let resultArr = {};

    Array.from(params).forEach(element => {
        let type = typeof (element);

        if (resultArr[type] == undefined) {
            resultArr[type] = [];
        }
        resultArr[type].push(element);

        console.log(`${type}: ${element}`);
    });


    for (const [key, value] of Object.entries(resultArr)) {
        console.log(`${key} = ${value.length}`);
    }

}

solve('dog', 'cat', 42, function () { console.log('Hello world!'); });