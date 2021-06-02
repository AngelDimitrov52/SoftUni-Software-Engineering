function carFactory(obj) {
    let result = {};
    result.model = obj.model;

    result.engine = {};
    let enginePower = Number(obj.power);
    let enginevolume = 0;
    if (enginePower <= 90) {
        enginePower = 90;
        enginevolume = 1800;
    }
    else if (enginePower <= 120) {
        enginePower = 120;
        volume = 2400;
    }
    else if (enginePower <= 200) {
        enginePower = 200;
        enginevolume = 3500;
    }
    result.engine.power = enginePower;
    result.engine.volume = enginevolume;

    result.carriage = {};
    result.carriage.type = obj.carriage;
    result.carriage.color = obj.color;

    if (obj.wheelsize % 2 === 0) {
        obj.wheelsize--;
    }

    result.wheels = [];
    for (let index = 0; index < 4; index++) {
        result.wheels.push(obj.wheelsize);

    }


    return result;
}

console.log(carFactory({
    model: 'VW Golf II',
    power: 90,
    color: 'blue',
    carriage: 'hatchback',
    wheelsize: 14
}
));