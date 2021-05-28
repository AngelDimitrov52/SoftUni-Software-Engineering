function rotate(array , num) {

    for (let index = 0; index < num; index++) {
        
        let element = array.pop();
        array.unshift(element);
    }

    console.log(array.join(' '));


}
//rotate(['1', '2', '3', '4'], 2);
rotate(['Banana', 
'Orange', 
'Coconut', 
'Apple'], 
15
);