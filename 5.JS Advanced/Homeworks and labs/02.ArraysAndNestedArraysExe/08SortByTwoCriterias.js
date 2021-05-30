function sortTwo(array) {

    array.sort((a, b) => {
        let numA = Number(a.length);
        let numB = Number(b.length);
        if (numA == numB) return sortAssending(a ,b);
        if (numA > numB) return 1;
        return -1;
    })

    function sortAssending(a ,b) {
        a = a.toUpperCase();
        b = b.toUpperCase();
        if (a == b) return 0;
        if (a > b) return 1;
        return -1;
        
    }
    
    array.forEach(element => {
        console.log(element);
    });
    
}
sortTwo(['test', 
'Deny', 
'omen', 
'Default']
);
sortTwo(['Isacc', 
'Theodor', 
'Jack', 
'Harrison', 
'George']

);
sortTwo(['alpha', 
'beta', 
'gamma']
);