import memesService from '../services/memesService.js';
import { html } from './../node_modules/lit-html/lit-html.js';
import notification from './notification.js';

let editTemplate = (form) => html`
<!-- Edit Meme Page ( Only for logged user and creator to this meme )-->
<section id="edit-meme">
    <form @submit=${(e)=> form.submitHandler(form.meme._id, e)} id="edit-form">
        <h1>Edit Meme</h1>
        <div class="container">
            <label for="title">Title</label>
            <input id="title" type="text" placeholder="Enter Title" name="title" .value=${form.meme.title}>
            <label for="description">Description</label>
            <textarea id="description" placeholder="Enter Description" name="description" .value=${form.meme.description}>
                </textarea>
            <label for="imageUrl">Image Url</label>
            <input id="imageUrl" type="text" placeholder="Enter Meme ImageUrl" name="imageUrl" .value=${form.meme.imageUrl}>
            <input type="submit" class="registerbtn button" value="Edit Meme">
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

async function submitHandler(id ,e) {
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
            let templateResult = editTemplate(_form);
            notification.getView(errors.join('\n'));
            //alert(errors.join('\n'));
            return _renderHandler(templateResult);
        }

        let user = {
            title,
            description,
            imageUrl
        }

        await memesService.update(user , id);
        _router.redirect(`/detail/${id}`);


    } catch (error) {
        alert(error);
    }



}

async function getView(context) {

    let id = context.params.id;
    let meme = await memesService.get(id);

    _form = {
        submitHandler,
        meme
    }
    
    let templateResult = editTemplate(_form);
    _renderHandler(templateResult);
    
}

export default {
    getView,
    initialize
}