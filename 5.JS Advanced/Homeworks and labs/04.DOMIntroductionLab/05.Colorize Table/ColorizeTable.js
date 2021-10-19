function colorize() {
    let allCol = document.querySelectorAll('table tr');

    let index = 0;
    for (const row of allCol) {
        index++;
        if (index % 2 === 0) {
            row.style.background = 'teal'
        }

    }

}