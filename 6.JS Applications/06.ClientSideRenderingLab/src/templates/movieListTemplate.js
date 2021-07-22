import { html } from '../../node_modules/lit-html/lit-html.js';
import movieTemplate from './movieTemplate.js'


export default (movies) => html`
<h3>Movie List</h3>
<ul class="movie-list">
    ${movies.map(x => html`${movieTemplate(x)}`)}
</ul>
    `;