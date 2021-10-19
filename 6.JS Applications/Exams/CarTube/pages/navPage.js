import authService from '../services/authService.js';
import { html } from './../node_modules/lit-html/lit-html.js';

let navTemplate = (model) => html`
<nav>
                <a class="active" href="/home">Home</a>
                <a href="/all-listings">All Listings</a>
                <a href="/by-year">By Year</a>
                ${model.isLogged
                ?html`   <!-- Logged users -->
                <div id="profile">
                    <a>Welcome ${model.user.username}</a>
                    <a href="/my-listings">My Listings</a>
                    <a href="/create">Create Listing</a>
                    <a href="javascript:void(0)" @click=${model.logoutFunc}>Logout</a>
                </div>` 
                :  html` <div id="guest">
                    <a href="/login">Login</a>
                    <a href="/register">Register</a>
                </div>`}
            </nav>
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
    let isLogged = false;
    let user = authService.getUser();

    if (user !== undefined) {
        isLogged = true;
    }
    let model = {
        isLogged,
        user,
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