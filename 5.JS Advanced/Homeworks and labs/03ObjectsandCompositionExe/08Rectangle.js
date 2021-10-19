function rectangle(width, height, color) {
    let result = {}
    result.width = Number(width);
    result.height = Number(height);
    result.color = color.charAt(0).toUpperCase() + color.slice(1);;
    result.calcArea = function (width, height) {
        const area =  result.width * result.height;
        return area;
    }

    return result;
}


let rect = rectangle(4, 5, 'red');
console.log(rect.width);
console.log(rect.height);
console.log(rect.color);
console.log(rect.calcArea());
