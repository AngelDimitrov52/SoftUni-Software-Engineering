function solve() {
  let input = Array.from(document.getElementById('input')
    .value
    .split('.')
    .filter(x => x.length > 0)
    .map(x => x + '.'));

  let output = document.getElementById('output');

  for (let i = 0; i < input.length; i += 3) {
    let arr = [];
    for (let y = 0; y < 3; y++) {
      if (input[i + y]) {
        arr.push(input[i + y]);
      }
    }
    let paragraph = arr.join('. ');
    output.innerHTML += `<p>${paragraph}</p>`;
  }

}