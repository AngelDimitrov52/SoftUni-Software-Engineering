function addRemove(array) {
    let num = 0;
    let addedArray = [];
    for (let index = 0; index < array.length; index++) {
        num++;
        if (array[index] === 'add') {
            addedArray.push(num);
            
        }  else{
            addedArray.pop();
        }
    }

    if (addedArray.length === 0) {
        console.log('Empty');
    }
    else{
        addedArray.forEach(el => {
            console.log(el);
        });
    }

}
addRemove(['add',
    'add',
    'add',
    'add']
);
addRemove(['add', 
'add', 
'remove', 
'add', 
'add']

);
addRemove(['remove', 
'remove', 
'remove']

);