import authService from '../services/authService.js';
import { html } from './../node_modules/lit-html/lit-html.js';

let registerTemplate = (form) => html`
    <!-- Register Page -->
    <section id="register">
            <div class="container">
                <form  @submit=${form.submitHandler} id="register-form">
                    <h1>Register</h1>
                    <p>Please fill in this form to create an account.</p>
                    <hr>

                    <p>Username</p>
                    <input type="text" placeholder="Enter Username" name="username" required>

                    <p>Password</p>
                    <input type="password" placeholder="Enter Password" name="password" required>

                    <p>Repeat Password</p>
                    <input type="password" placeholder="Repeat Password" name="repeatPass" required>
                    <hr>

                    <input type="submit" class="registerbtn" value="Register">
                </form>
                <div class="signin">
                    <p>Already have an account?
                        <a href="/login">Sign in</a>.
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
        let repeatPass = formData.get('repeatPass');

        
        if (username.trim() == '') {
            errors.push('Username is required!')
        }
        if (password.trim() == '') {
            errors.push('Password is required!')
        }
        if (repeatPass.trim() == '') {
            errors.push('RepeatPass is required!')
        }

        if (errors.length > 0) {
            let templateResult = registerTemplate(_form);
            alert(errors.join('\n'));
            return _renderHandler(templateResult);
        }

        let user = {
            username,
            password,
        }

        await authService.register(user);
        _router.redirect('/all-listings');


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