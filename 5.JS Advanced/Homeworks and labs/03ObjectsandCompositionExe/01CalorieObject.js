function calorie(array) {
    const result = {};
    for (let index = 0; index < array.length; index += 2) {
        const name = array[index];
        const num = Number(array[index + 1])
        result[name] = num;
    }
    console.log(result);
}
calorie(['Yoghurt', '48', 'Rise', '138', 'Apple', '52']);