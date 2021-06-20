class List {

    constructor() {
        this.resultArr = [];
        this.size = 0;
    }

    add(value) {
        this.resultArr.push(value);
        this.size++;
        this.resultArr.sort((a, b) => a - b);


    }
    remove(index) {
        if (index < 0 || index >= this.resultArr.length) {
            throw new Error
        }
        this.size--;
        this.resultArr.splice(index, 1);
    }
    get(index) {
        if (index < 0 || index >= this.resultArr.length) {
            throw new Error
        }
        return this.resultArr[index];
    }


}





let list = new List();
list.add(7);
list.add(6);
list.add(5);
console.log(list.get(1));
list.remove(1);
console.log(list.size);
console.log(list.get(1));
