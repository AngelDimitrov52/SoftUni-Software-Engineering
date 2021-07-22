let baseUrl = 'http://localhost:3030'

function getAllMovies() {
    return fetch(`${baseUrl}/data/movies`)
        .then(res => res.json());
}


export default {
    getAllMovies,
}