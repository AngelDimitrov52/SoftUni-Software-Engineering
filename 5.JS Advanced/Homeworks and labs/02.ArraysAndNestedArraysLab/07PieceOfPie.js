function piece(array, first, second) {

    let firstIndex = array.indexOf(first);
    let secondIndex = array.indexOf(second);

    let newArr = array.slice(firstIndex, secondIndex + 1)

    return newArr;

}

piece(['Pumpkin Pie',
    'Key Lime Pie',
    'Cherry Pie',
    'Lemon Meringue Pie',
    'Sugar Cream Pie'],
    'Key Lime Pie',
    'Lemon Meringue Pie'
);
piece(['Apple Crisp',
    'Mississippi Mud Pie',
    'Pot Pie',
    'Steak and Cheese Pie',
    'Butter Chicken Pie',
    'Smoked Fish Pie'],
    'Pot Pie',
    'Smoked Fish Pie'

);