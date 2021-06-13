function solve(array) {
    const cars = carFunction();



    array.forEach(element => {
        let comandArgs = element.split(' ');
        let comand = comandArgs[0];
        let thisName = comandArgs[1];
        let thisProp = comandArgs[2];
        let thisvalue = comandArgs[3];

        if (comand === 'create' && comandArgs.length === 4) {
            cars.createInherit(thisName, thisvalue)
        }
        else if (comand === 'create') {
            cars.create(thisName)
        }

        else if (comand === 'set') {

            cars.set(thisName, thisProp, thisvalue)
        }
        else if (comand === 'print') {
            cars.print(thisName);
        }
    });

    function carFunction(params) {
        let result = {};
        return {
            create: create,
            createInherit: createInherit,
            set: set,
            print: print,
        }

        function create(name) {
            result[name] = {}
        }
        function createInherit(name, naprenName) {
            result[name] = Object.create(result[naprenName])
        }
        function set(name, prop, value) {
            result[name][prop] = value;
        }
        function print(name) {
            let logs = [];

            for (const key in result[name]) {

                logs.push(`${key}:${result[name][key]}`)
            }

            console.log(logs.join(', '));
        }

    }

}

solve(['create c1',
    'create c2 inherit c1',
    'set c1 color red',
    'set c2 model new',
    'print c1',
    'print c2']
);