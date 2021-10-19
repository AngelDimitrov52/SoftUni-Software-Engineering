function solve() {
  const [generateButton, byButton] = Array.from(document.querySelectorAll('button'));
  const [inputTextArea, outputTextArea] = Array.from(document.querySelectorAll('textarea'));
  const tbody = document.querySelector('tbody');

  generateButton.addEventListener('click', addedNewProducts)
  byButton.addEventListener('click', buyAll)

  function addedNewProducts() {
    JSON.parse(inputTextArea.value).forEach(el => {
      let furnitureStructure = `
    <tr>
     <td><img src="${el.img}"></td>
     <td><p>${el.name}</p></td> 
     <td><p>${el.price}</p></td>
     <td><p>${el.decFactor}</p></td>
     <td><input type="checkbox"/></td>
    </tr>`

      tbody.insertAdjacentHTML(`beforeend`, furnitureStructure);
    });
  }

  function buyAll() {
    const furniture = Array.from(document.querySelectorAll('input[type=checkbox]:checked'))
      .map(input => input.parentElement.parentElement);

    const result = {
      name: [],
      totalPrice: 0,
      decFactor: 0
    };

    for (let row of furniture) {
      const cells = row.children;

      const name = cells[1].children[0].textContent;
      result.name.push(name);

      const price = Number(cells[2].children[0].textContent);
      result.totalPrice += price;

      const factor = Number(cells[3].children[0].textContent);
      result.decFactor += factor;
    }

    outputTextArea.value = `Bought furniture: ${result.name.join(', ')}\nTotal price: ${result.totalPrice.toFixed(2)}\nAverage decoration factor: ${result.decFactor / furniture.length}`;
  }
}

