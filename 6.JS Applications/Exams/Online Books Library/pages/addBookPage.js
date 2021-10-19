import booksService from '../services/booksService.js';
import { html } from './../node_modules/lit-html/lit-html.js';



let createTemplate = (form) => html`
<!-- Create Page ( Only for logged-in users ) -->
<section id="create-page" class="create">
            <form  @submit=${form.submitHandler} id="create-form" action="" method="">
                <fieldset>
                    <legend>Add new Book</legend>
                    <p class="field">
                        <label for="title">Title</label>
                        <span class="input">
                            <input type="text" name="title" id="title" placeholder="Title">
                        </span>
                    </p>
                    <p class="field">
                        <label for="description">Description</label>
                        <span class="input">
                            <textarea name="description" id="description" placeholder="Description"></textarea>
                        </span>
                    </p>
                    <p class="field">
                        <label for="image">Image</label>
                        <span class="input">
                            <input type="text" name="imageUrl" id="image" placeholder="Image">
                        </span>
                    </p>
                    <p class="field">
                        <label for="type">Type</label>
                        <span class="input">
                            <select id="type" name="type">
                                <option value="Fiction">Fiction</option>
                                <option value="Romance">Romance</option>
                                <option value="Mistery">Mistery</option>
                                <option value="Classic">Clasic</option>
                                <option value="Other">Other</option>
                            </select>
                        </span>
                    </p>
                    <input class="button submit" type="submit" value="Add Book">
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

        let title = formData.get('title');
        let description = formData.get('description');
        let imageUrl = formData.get('imageUrl');
        let type = formData.get('type');


        if (title.trim() == '') {
            errors.push('Title is required!')
        }
        if (description.trim() == '') {
            errors.push('Description is required!')
        }
        if (imageUrl.trim() == '') {
            errors.push('ImageUrl is required!')
        }
        if (type.trim() == '' ) {
            errors.push('Type is required!')
        }


        if (errors.length > 0) {
            let templateResult = createTemplate(_form);
            alert(errors.join('\n'));
            return _renderHandler(templateResult);
        }

        let car = {
            title,
            description,
            imageUrl,
            type
        }

        await booksService.create(car);
        _router.redirect('/dashboard');


    } catch (error) {
        alert(error);
    }



}

async function getView() {
    _form = {
        submitHandler,
    }
    let templateResult = createTemplate(_form);
    _renderHandler(templateResult);
}

export default {
    getView,
    initialize
}