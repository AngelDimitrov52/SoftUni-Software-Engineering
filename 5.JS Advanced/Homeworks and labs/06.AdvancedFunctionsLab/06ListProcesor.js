function solve(arr) {
    let result = [];
    arr.forEach(element => {
        let [comand, text] = element.split(' ');

        if (comand === 'add') {
            add(text);
        }
        else if (comand === 'remove') {
            remove(text);
        }
        else if (comand === 'print') {
            print()
        }
    });

    function add(str) {
        result.push(str);
    }
    function remove(str) {
        result = result.filter(f => f !== str);

    }
    function print() {
        console.log(result.join(','));
    }
}

solve(['add hello', 'add again', 'remove hello', 'add again', 'print']);