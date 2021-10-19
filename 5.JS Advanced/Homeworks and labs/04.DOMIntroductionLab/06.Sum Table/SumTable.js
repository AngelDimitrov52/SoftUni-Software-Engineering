function sumTable() {
    let table = document.querySelectorAll("table tr");
    let sum = 0;

    for (let index = 1; index < table.length; index++) {
        let colons = table[index].children;
        let curentcol = colons[colons.length - 1].textContent;

        sum += Number(curentcol);

    }

    document.getElementById("sum").textContent = sum;

}