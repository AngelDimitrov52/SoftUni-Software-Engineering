function extractText() {
    let listItems = document.querySelectorAll("ul#items li");
    
    let resultSelect = document.querySelector("#result")

    for (const item of listItems) {
        resultSelect.value += item.textContent + '\n'
    }
}