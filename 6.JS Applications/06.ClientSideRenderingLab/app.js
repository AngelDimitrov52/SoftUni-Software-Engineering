import { render, html } from './node_modules/lit-html/lit-html.js';
import movieListTemplate from './src/templates/movieListTemplate.js';
import movieService from './src/templates/services/movieService.js';

let rootElemet = document.getElementById('root');

movieService.getAllMovies()
.then(movies => {
    let movieListTemplateResult = movieListTemplate(movies);
    render(movieListTemplateResult, rootElemet)
})

