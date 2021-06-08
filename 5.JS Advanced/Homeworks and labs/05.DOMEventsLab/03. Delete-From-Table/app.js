function deleteByEmail() {
    let tableElemnts = document.querySelectorAll('tbody tr');
    let input = document.getElementsByTagName('input')[0].value;
    let resultElement = document.getElementById('result');

    let result = 'Not found.';
    Array.from(tableElemnts).forEach(tr => {
        if (tr.children[1].textContent === input) {
            result = 'Deleted';
            tr.remove();
        }

    });

    resultElement.textContent = result;
}