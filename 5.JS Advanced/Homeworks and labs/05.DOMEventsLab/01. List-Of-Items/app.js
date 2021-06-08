function addItem() {
    let input = document.getElementById('newItemText').value;
    let liElement = document.createElement("li");
    liElement.appendChild(document.createTextNode(input));
    document.getElementById("items").appendChild(liElement);
      
    document.getElementById('newItemText').value = '';
  } 
  