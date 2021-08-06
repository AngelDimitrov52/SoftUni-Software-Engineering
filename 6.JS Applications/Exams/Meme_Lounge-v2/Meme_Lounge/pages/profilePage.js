import authService from '../services/authService.js';
import memesService from '../services/memesService.js';
import { html } from './../node_modules/lit-html/lit-html.js';

let profileTemplate = (model) => html`       
<!-- Profile Page ( Only for logged users ) -->
<section id="user-profile-page" class="user-profile">
    <article class="user-info">
        <img id="user-avatar-url" alt="user-profile" src=${model.user.gender==='female'
        ? '/images/female.png'
        : '/images/male.png'}> 
        <div class="user-content">
        <p>Username: ${model.user.username}</p>
        <p>Email: ${model.user.email}</p>
        <p>My memes count: ${model.memes.length}</p>
        </div>
    </article>
    <h1 id="user-listings-title">User Memes</h1>
    <div class="user-meme-listings">
        ${model.memes.length >0 
        ? model.memes.map(x => memeTemplete(x))
    : html`<p class="no-memes">No memes in database.</p>` }
    </div>
</section>`;

let memeTemplete = (meme) => html`<div class="user-meme">
            <p class="user-meme-title">${meme.title}</p>
            <img class="userProfileImage" alt="meme-img" src="${meme.imageUrl}">
            <a class="button" href="/detail/${meme._id}">Details</a>
        </div>`;


let _router = undefined;
let _renderHandler = undefined;

function initialize(router, renderHandler) {
    _router = router;
    _renderHandler = renderHandler;
}


async function getView(context) {
    
    let user = authService.getUser();

    let id = user._id;
    let memes = await memesService.getMyMemes(id);



    let model = {
        memes,
        user
    }

    let templateResult = profileTemplate(model);
    _renderHandler(templateResult);
}

export default {
    getView,
    initialize
}
