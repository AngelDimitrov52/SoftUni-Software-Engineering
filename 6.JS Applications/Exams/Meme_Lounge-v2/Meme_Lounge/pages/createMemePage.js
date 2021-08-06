import memesService from '../services/memesService.js';
import { html } from './../node_modules/lit-html/lit-html.js';
import notification from './notification.js';

let createTemplate = (form) => html`
<!-- Create Meme Page ( Only for logged users ) -->
<section id="create-meme">
    <form @submit=${form.submitHandler} id="create-form">
        <div class="container">
            <h1>Create Meme</h1>
            <label for="title">Title</label>
            <input id="title" type="text" placeholder="Enter Title" name="title">
            <label for="description">Description</label>
            <textarea id="description" placeholder="Enter Description" name="description"></textarea>
            <label for="imageUrl">Meme Image</label>
            <input id="imageUrl" type="text" placeholder="Enter meme ImageUrl" name="imageUrl">
            <input type="submit" class="registerbtn button" value="Create Meme">
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

        let title = formData.get('title');
        let description = formData.get('description');
        let imageUrl = formData.get('imageUrl');


        if (title.trim() == '') {
            errors.push('Title is required!')
        }
        if (description.trim() == '') {
            errors.push('Description is required!')
        }
        if (imageUrl.trim() == '') {
            errors.push('ImageUrl is required!')
        }

        if (errors.length > 0) {
            let templateResult = createTemplate(_form);
            notification.getView(errors.join('\n'));
            //alert(errors.join('\n'));
            return _renderHandler(templateResult);
        }

        let user = {
            title,
            description,
            imageUrl
        }

        await memesService.create(user);
        _router.redirect('/all-memes');


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