function loadCommits() {
    let username = document.getElementById('username').value;
    let repo = document.getElementById('repo').value;
    let ulElemet = document.getElementById('commits');


    let url = `https://api.github.com/repos/${username}/${repo}/commits`;

    fetch(url)
        .then((responce) => {
            if (responce.ok) {
                return responce.json()
            }
            else {
                throw new Error(responce.status);
            }
        })
        .then((data) => {
            data.forEach(object => {
                let liElement = document.createElement('li');
                liElement.textContent = `${object.commit.author.name}: ${object.commit.message}`;
                ulElemet.appendChild(liElement);
            })

        })
        .catch((error) => {
            let liElement = document.createElement('li');
            liElement.textContent = `Error: ${error.message} (Not found)`
            ulElemet.appendChild(liElement);
        })

}