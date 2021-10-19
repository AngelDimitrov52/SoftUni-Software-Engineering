function print(array , num) {
    let newArray = [];
    for (let index = 0; index < array.length; index+=num) {
        newArray.push(array[index]);
        
    }
    return newArray;
}
print(['5', 
'20', 
'31', 
'4', 
'20'], 
2
);
print(['dsa',
'asd', 
'test', 
'tset'], 
2
);
print(['1', 
'2',
'3', 
'4', 
'5'], 
6
);