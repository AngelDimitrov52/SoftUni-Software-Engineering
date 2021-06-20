function createTickets(arr, sortWord) {
    class Ticket {
        constructor(destination, price, status) {
            this.destination = destination;
            this.price = price;
            this.status = status;
        }
    }
    let resultArr = [];
    arr.forEach(element => {
        let [destination, price, status] = element.split('|');
        price = Number(price);

        let ticket = new Ticket(destination, price, status);
        resultArr.push(ticket);

    });

      if (sortWord === 'price') {
        resultArr.sort((a,b) => a[sortWord] - b[sortWord]);
      } else{
        resultArr.sort((a,b) => a[sortWord].localeCompare(b[sortWord]));
      }

 
    return resultArr;
}


createTickets(['Philadelphia|94.20|available',
'New York City|95.99|available',
'New York City|95.99|sold',
'Boston|126.20|departed'],
'status'
);