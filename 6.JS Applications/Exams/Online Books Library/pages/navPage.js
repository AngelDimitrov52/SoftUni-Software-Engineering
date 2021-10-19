import authService from '../services/authService.js';
import { html } from './../node_modules/lit-html/lit-html.js';

let navTemplate = (model) => html`
    <!-- Navigation -->
    <nav class="navbar">
        <section class="navbar-dashboard">
            <a href="/dashboard">Dashboard</a>
            ${model.isLogged === false
            ? html`
            <!-- Guest users -->
            <div id="guest">
                <a class="button" href="/login">Login</a>
                <a class="button" href="/register">Register</a>
            </div>`
            : html`
            <!-- Logged-in users -->
            <div id="user">
                <span>Welcome, ${model.user.email}</span>
                <a class="button" href="/my-books">My Books</a>
                <a class="button" href="/add-book">Add Book</a>
                <a class="button" href="javascript:void(0)" @click=${model.logoutFunc}>Logout</a>
            </div>`}
        </section>
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
    _router.redirect('/dashboard');

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