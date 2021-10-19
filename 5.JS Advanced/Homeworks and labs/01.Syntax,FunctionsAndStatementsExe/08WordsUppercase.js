function upper(param) {

    const reg = /\W+/;
    let text = String(param);
    let array = text.split(reg);

    let filterArray = array.filter(item => item);

    const uppercased = filterArray.map(name => name.toUpperCase());

    console.log(uppercased.join(', '));
}

upper('Hi, how are you?');
upper('hello');