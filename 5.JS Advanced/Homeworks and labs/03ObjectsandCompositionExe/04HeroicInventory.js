function solve(arraySolve) {
    let result = [];
    for (let index = 0; index < arraySolve.length; index++) {

        let [name, level, items] = arraySolve[index].split(' / ');
        level = Number(level);
        items = items ? items.split(', ') : [];

        result.push({ name, level, items })
    }
    console.log(JSON.stringify(result));

}
solve(['Isacc / 25 / Apple',
    'Derek / 12 / BarrelVest, DestructionSword',
    'Hes / 1 / Desolator, Sentinel, Antara']
);