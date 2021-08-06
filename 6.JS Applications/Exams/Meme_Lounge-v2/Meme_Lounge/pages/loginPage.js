import authService from '../services/authService.js';
import { html } from './../node_modules/lit-html/lit-html.js';
import notification from './notification.js';

let loginTemplate = (form) => html`
<!-- Login Page ( Only for guest users ) -->
<section id="login">
    <form @submit=${form.submitHandler} id="login-form">
        <div class="container">
            <h1>Login</h1>
            <label for="email">Email</label>
            <input id="email" placeholder="Enter Email" name="email" type="text">
            <label for="password">Password</label>
            <input id="password" type="password" placeholder="Enter Password" name="password">
            <input type="submit" class="registerbtn button" value="Login">
            <div class="container signin">
                <p>Dont have an account?<a href="/register">Sign up</a>.</p>
            </div>
        </div>
    </form>
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

        let email = formData.get('email');
        let password = formData.get('password');


        if (email.trim() == '') {
            errors.push('Email is required!')
        }
        if (password.trim() == '') {
            errors.push('Password is required!')
        }

        if (errors.length > 0) {
            let templateResult = loginTemplate(_form);
           notification.getView(errors.join('\n'));
            //alert(errors.join('\n'));
            return _renderHandler(templateResult);
        }

        let user = {
            email,
            password
        }

        await authService.login(user);
        _router.redirect('/all-memes');


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