
import authService from '../services/authService.js';
import { html } from './../node_modules/lit-html/lit-html.js';

let loginTemplate = (form) => html`
 <section id="login">
<div class="container">
    <form @submit=${form.submitHandler} id="login-form" action="#" method="post">
        <h1>Login</h1>
        <p>Please enter your credentials.</p>
        <hr>

        <p>Username</p>
        <input placeholder="Enter Username" name="username" type="text">

        <p>Password</p>
        <input type="password" placeholder="Enter Password" name="password">
        <input type="submit" class="registerbtn" value="Login">
    </form>
    <div class="signin">
        <p>Dont have an account?
            <a href="/register">Sign up</a>.
        </p>
    </div>
</div>
</section>`;

let _router = undefined;
let _renderHandler = undefined;
let _form = undefined;


function initialize(router, renderHandler) {
    _router = router;
    _renderHandler = renderHandler;
}

async function submitHandler(e) {
    e.preventDefault();
    try {
        let errors = [];
        let formData = new FormData(e.target);

        let username = formData.get('username');
        let password = formData.get('password');


        if (username.trim() == '') {
            errors.push('Username is required!')
        }
        if (password.trim() == '') {
            errors.push('Password is required!')
        }

        if (errors.length > 0) {
            let templateResult = loginTemplate(_form);
            alert(errors.join('\n'));
            return _renderHandler(templateResult);
        }

        let user = {
            username,
            password
        }

        await authService.login(user);
        _router.redirect('/all-listings');


    } catch (error) {
        alert(error);
    }

}

async function getView() {
    _form = {
        submitHandler,
    }
    let templateResult = loginTemplate(_form);
    _renderHandler(templateResult);
    
}

export default {
    getView,
    initialize
}