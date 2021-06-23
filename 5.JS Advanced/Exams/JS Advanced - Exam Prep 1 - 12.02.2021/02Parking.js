class Parking {
    constructor(capacity) {
        this.capacity = Number(capacity);
        this.vehicles = [];
    }

    addCar(carModel, carNumber) {

        if (this.capacity == this.vehicles.length) {
            throw new Error("Not enough parking space.");
        }
        this.vehicles.push({
            carModel: carModel,
            carNumber: carNumber,
            payed: false,
        });
        return `The ${carModel}, with a registration number ${carNumber}, parked.`
    }

    removeCar(carNumber) {
        let car = this.vehicles.find(x => x.carNumber == carNumber);
        if (!car) {
            throw new Error("The car, you're looking for, is not found.");
        }
        if (car.payed == false) {
            throw new Error(`${carNumber} needs to pay before leaving the parking lot.`)
        }
        this.vehicles = this.vehicles.filter(car => car.carNumber != carNumber);

        return `${carNumber} left the parking lot.`;
    }

    pay(carNumber) {
        let car = this.vehicles.find(x => x.carNumber == carNumber);
        if (!car) {
            throw new Error(`${carNumber} is not in the parking lot.`);
        }
        if (car.payed == true) {
            throw new Error(`${carNumber}'s driver has already payed his ticket.`)
        }
        car.payed = true;
        return `${carNumber}'s driver successfully payed for his stay.`
    }

    getStatistics(carNumber) {
        if (carNumber) {
            let car = this.vehicles.find(x => x.carNumber == carNumber);
            let result = `${car.carModel} == ${car.carNumber} - `
            if (car.payed == false) {
                result += 'Not payed'
            }
            else {
                result += 'Has payed'
            }
            return result;
        }
        else {
            let result = `The Parking Lot has ${this.capacity - this.vehicles.length} empty spots left.`
            this.vehicles = this.vehicles = this.vehicles.sort((a, b) => a.carModel.localeCompare(b.carModel));
            this.vehicles.forEach(car => {
                let carResult = `\n${car.carModel} == ${car.carNumber} - `
                if (car.payed == false) {
                    carResult += 'Not payed'
                }
                else {
                    carResult += 'Has payed'
                }
                result += carResult

            });
            return result;
        }

    }
}



const parking = new Parking(2);

console.log(parking.addCar("Volvo t600", "TX3691CA"));
//console.log(parking.addCar("Aolvo t600", "TX3691Cb"));
console.log(parking.getStatistics());

//console.log(parking.pay("TX3691CA"));
//console.log(parking.pay("TX3691CA"));
console.log(parking.removeCar("TX3691Cb"));
//console.log(parking.removeCar("TX3691Cb"));
console.log(parking.getStatistics());
