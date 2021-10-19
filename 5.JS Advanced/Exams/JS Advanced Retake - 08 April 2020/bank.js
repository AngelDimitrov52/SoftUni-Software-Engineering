class Bank {
    constructor(bankName) {
        this._bankName = bankName;
        this.allCustomers = [];
        this.save = []
    }

    newCustomer(customer) {
        if (this.allCustomers.some(x => x.personalId === customer.personalId)) {
            throw new Error(`${customer.firstName} ${customer.lastName} is already our customer!`);
        }
        let id = customer.personalId;
        let obj = {
            Id: id,
            arr: []
        };
        this.save.push(obj)
        this.allCustomers.push(customer)
        return customer
    }
    depositMoney(personalId, amount) {
        let contumer = this.allCustomers.find(x => x.personalId === personalId)
        if (!contumer) {
            throw new Error(`We have no customer with this ID!`);
        }
        if (!contumer.totalMoney) {
            contumer.totalMoney = 0;
        }

        contumer.totalMoney += amount;

        let obj = this.save.find(x => x.Id === personalId);
        obj.arr.push(`made deposit of ${amount}$!`);

        return `${contumer.totalMoney}$`;
    }
    withdrawMoney(personalId, amount) {
        let contumer = this.allCustomers.find(x => x.personalId === personalId)
        if (!contumer) {
            throw new Error(`We have no customer with this ID!`);
        }
        if (contumer.totalMoney < amount) {
            throw new Error(`${contumer.firstName} ${contumer.lastName} does not have enough money to withdraw that amount!`);
        }
        contumer.totalMoney -= amount;

        let obj = this.save.find(x => x.Id === personalId);
        obj.arr.push(`withdrew ${amount}$!`);

        return `${contumer.totalMoney}$`;
    }
    customerInfo(personalId) {
        let contumer = this.allCustomers.find(x => x.personalId === personalId)
        if (!contumer) {
            throw new Error(`We have no customer with this ID!`);
        }
        let result = `Bank name: ${this._bankName}`;
        result += `\nCustomer name: ${contumer.firstName} ${contumer.lastName}`;
        result += `\nCustomer ID: ${contumer.personalId}`;
        result += `\nTotal Money: ${contumer.totalMoney}$`;
        result += `\nTransactions:`

        let obj = this.save.find(x => x.Id === personalId);
        let array = obj.arr.reverse();
        let n = array.length;
        array.forEach(operatin => {

            result += `\n${n--}. ${contumer.firstName} ${contumer.lastName} ${operatin}`
        });
        return result.trim();


    }
}

let bank = new Bank('SoftUni Bank');

console.log(bank.newCustomer({ firstName: 'Svetlin', lastName: 'Nakov', personalId: 6233267 }));
console.log(bank.newCustomer({ firstName: 'Mihaela', lastName: 'Mileva', personalId: 4151596 }));

bank.depositMoney(6233267, 250);
console.log(bank.depositMoney(6233267, 250));
bank.depositMoney(4151596, 555);

console.log(bank.withdrawMoney(6233267, 125));

console.log(bank.customerInfo(6233267));



