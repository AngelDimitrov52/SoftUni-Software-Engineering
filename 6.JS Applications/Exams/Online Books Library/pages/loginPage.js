
import authService from '../services/authService.js';
import { html } from './../node_modules/lit-html/lit-html.js';

let loginTemplate = (form) => html`
  <!-- Login Page ( Only for Guest users ) -->
  <section id="login-page" class="login">
            <form  @submit=${form.submitHandler} id="login-form" action="" method="">
                <fieldset>
                    <legend>Login Form</legend>
                    <p class="field">
                        <label for="email">Email</label>
                        <span class="input">
                            <input type="text" name="email" id="email" placeholder="Email">
                        </span>
                    </p>
                    <p class="field">
                        <label for="password">Password</label>
                        <span class="input">
                            <input type="password" name="password" id="password" placeholder="Password">
                        </span>
                    </p>
                    <input class="button submit" type="submit" value="Login">
                </fieldset>
            </form>
        </section>
        `;

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
            alert(errors.join('\n'));
            return _renderHandler(templateResult);
        }

        let user = {
            email,
            password
        }

        await authService.login(user);
        _router.redirect('/dashboard');


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