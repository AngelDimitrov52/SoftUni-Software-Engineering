import authService from '../services/authService.js';
import { html } from './../node_modules/lit-html/lit-html.js';

let navTemplate = (model) => html`
<a href="/all-memes">All Memes</a>
${!model.isLogged
? html`
<!-- Guest users -->
<div class="guest">
    <div class="profile">
        <a href="/login">Login</a>
        <a href="/register">Register</a>
    </div>
    <a class="active" href="/home">Home Page</a>
</div>`
: html`
<!-- Logged users -->
<div class="user">
    <a href="/create">Create Meme</a>
    <div class="profile">
        <span>Welcome, ${model.email}</span>
        <a href="/profile">My Profile</a>
        <a href="javascript:void(0)" @click=${model.logoutFunc}>Logout</a>
    </div>
</div>`}
`;


let _router = undefined;
let _renderHandler = undefined;

function initialize(router, renderHandler) {
    _router = router;
    _renderHandler = renderHandler;
}

async function logoutFunc() {
    await authService.logout();
    _router.redirect('/home');

}

async function getView(context, next) {
    let email = undefined;
    let isLogged = false;
    let user = authService.getUser();

    if (user !== undefined) {
        email = user.email;
        isLogged = true;
    }
    let model = {
        email,
        isLogged,
        logoutFunc
    }

    let templateResult = navTemplate(model);
    _renderHandler(templateResult);
    next();
}

export default {
    getView,
    initialize
}