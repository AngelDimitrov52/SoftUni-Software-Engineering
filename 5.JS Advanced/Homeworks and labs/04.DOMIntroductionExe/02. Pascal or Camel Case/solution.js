function solve() {
  let inputElement = document.getElementById('text').value;
  let transformElement = document.getElementById('naming-convention').value;

  let inputStringArr = Array.from(inputElement.split(' '));
  let result = '';

  if (transformElement === "Camel Case") {

    result += inputStringArr[0].toLowerCase();
    for (let index = 1; index < inputStringArr.length; index++) {

      result += inputStringArr[index][0].toUpperCase() + inputStringArr[index].toLowerCase().slice(1);

    }
  }
  else if (transformElement === "Pascal Case") {

    for (let index = 0; index < inputStringArr.length; index++) {

      result += inputStringArr[index][0].toUpperCase() + inputStringArr[index].toLowerCase().slice(1);

    }

  } else {
    result = "Error!";
  }

  document.getElementById('result').textContent = result

}