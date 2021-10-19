import authService from '../services/authService.js';
import { html } from './../node_modules/lit-html/lit-html.js';
import notification from './notification.js';

let registerTemplate = (form) => html`
<!-- Register Page ( Only for guest users ) -->
<section id="register">
    <form @submit=${form.submitHandler} id="register-form">
        <div class="container">
            <h1>Register</h1>
            <label for="username">Username</label>
            <input id="username" type="text" placeholder="Enter Username" name="username">
            <label for="email">Email</label>
            <input id="email" type="text" placeholder="Enter Email" name="email">
            <label for="password">Password</label>
            <input id="password" type="password" placeholder="Enter Password" name="password">
            <label for="repeatPass">Repeat Password</label>
            <input id="repeatPass" type="password" placeholder="Repeat Password" name="repeatPass">
            <div class="gender">
                <input type="radio" name="gender" id="female" value="female">
                <label for="female">Female</label>
                <input type="radio" name="gender" id="male" value="male" checked>
                <label for="male">Male</label>
            </div>
            <input type="submit" class="registerbtn button" value="Register">
            <div class="container signin">
                <p>Already have an account?<a href="/login">Sign in</a>.</p>
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

        let username = formData.get('username');
        let email = formData.get('email');
        let password = formData.get('password');
        let repeatPass = formData.get('repeatPass');
        let gender = formData.get('gender');

        
        if (username.trim() == '') {
            errors.push('Username is required!')
        }
        if (email.trim() == '') {
            errors.push('Email is required!')
        }
        if (password.trim() == '') {
            errors.push('Password is required!')
        }
        if (repeatPass.trim() == '') {
            errors.push('RepeatPass is required!')
        }

        if (errors.length > 0) {
            let templateResult = registerTemplate(_form);
            notification.getView(errors.join('\n'));
            //alert(errors.join('\n'));
            return _renderHandler(templateResult);
        }

        let user = {
            username,
            email,
            password,
            gender
        }

        await authService.register(user);
        _router.redirect('/all-memes');


    } catch (error) {
        alert(error);
    }



}

async function getView() {
    _form = {
        submitHandler,
    }
    let templateResult = registerTemplate(_form);
    _renderHandler(templateResult);

}

export default {
    getView,
    initialize
}