function showText() {
    
    let textarea = document.querySelector("#text");
    textarea.style.display = 'inline';
    
    let text = textarea.textContent;

    for (let index = 0; index < 10; index++) {

        textarea.textContent += text;
        
    }

    document.getElementById('more').style.display = 'none';
}