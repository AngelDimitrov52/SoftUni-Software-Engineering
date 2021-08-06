import memesService from '../services/memesService.js';
import { html } from './../node_modules/lit-html/lit-html.js';

let allMemeTemplate = (memes) => html`
<!-- All Memes Page ( for Guests and Users )-->
<section id="meme-feed">
    <h1>All Memes</h1>
    <div id="memes">
        <!-- Display : All memes in database ( If any ) -->
        ${memes.length > 0
        ? memes.map(x => memeTemplate(x))
            : html`<p class="no-memes">No memes in database.</p>`}

        <!-- Display : If there are no memes in database -->
    </div>
</section>`;

let memeTemplate = (meme) => html`
<div class="meme">
    <div class="card">
        <div class="info">
            <p class="meme-title">${meme.title}</p>
            <img class="meme-image" alt="meme-img" src="${meme.imageUrl}">
        </div>
        <div id="data-buttons">
            <a class="button" href="/detail/${meme._id}">Details</a>
        </div>
    </div>
</div>`;


let _router = undefined;
let _renderHandler = undefined;

function initialize(router, renderHandler) {
    _router = router;
    _renderHandler = renderHandler;
}


async function getView() {
let memes = await memesService.getAllMemes();

    let templateResult = allMemeTemplate(memes);
    _renderHandler(templateResult);
}

export default {
    getView,
    initialize
}