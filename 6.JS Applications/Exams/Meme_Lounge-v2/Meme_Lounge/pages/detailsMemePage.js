import authService from '../services/authService.js';
import memesService from '../services/memesService.js';
import { html } from './../node_modules/lit-html/lit-html.js';

let detailsMemeTemplate = (model) => html` 
<!-- Details Meme Page (for guests and logged users) -->
<section id="meme-details">
    <h1>Meme Title: ${model.meme.title}</h1>
    <div class="meme-details">
        <div class="meme-img">
            <img alt="meme-alt" src="${model.meme.imageUrl}">
        </div>
        <div class="meme-description">
            <h2>Meme Description</h2>
            <p>
                ${model.meme.description}
            </p>
            ${model.isAutor
        ? html` <a class="button warning" href="/edit/${model.meme._id}">Edit</a>
            <button class="button danger" @click=${(e)=> model.deleteHandler(model.meme._id, e)}>Delete</button>`
        : ''}


        </div>
    </div>
</section>`;

let _router = undefined;
let _renderHandler = undefined;

function initialize(router, renderHandler) {
    _router = router;
    _renderHandler = renderHandler;
}


async function getView(context) {
    let id = context.params.id;
    let meme = await memesService.get(id);

    let user = authService.getUser();

    let isAutor = false;

    if (user !== undefined && user._id === meme._ownerId) {
        isAutor = true;
    }
    async function deleteHandler(id, e) {
        await memesService.deleteItem(id);
        _router.redirect('/all-memes');

    }

    let model = {
        meme,
        isAutor,
        deleteHandler
    }

    let templateResult = detailsMemeTemplate(model);
    _renderHandler(templateResult);
}

export default {
    getView,
    initialize
}