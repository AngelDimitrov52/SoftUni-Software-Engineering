import { html } from './../node_modules/lit-html/lit-html.js';
import booksService from '../services/booksService.js';


let editTemplate = (model) => html`
  <!-- Edit Page ( Only for the creator )-->
  <section id="edit-page" class="edit">
            <form  @submit=${(e)=> model.submitHandler(model.book._id, e)} id="edit-form" action="#" method="">
                <fieldset>
                    <legend>Edit my Book</legend>
                    <p class="field">
                        <label for="title">Title</label>
                        <span class="input">
                            <input type="text" name="title" id="title" value="${model.book.title}">
                        </span>
                    </p>
                    <p class="field">
                        <label for="description">Description</label>
                        <span class="input">
                            <textarea name="description"
                                id="description">${model.book.description}</textarea>
                        </span>
                    </p>
                    <p class="field">
                        <label for="image">Image</label>
                        <span class="input">
                            <input type="text" name="imageUrl" id="image" value="${model.book.imageUrl}">
                        </span>
                    </p>
                    <p class="field">
                        <label for="type">Type</label>
                        <span class="input">
                            <select id="type" name="type" value="${model.book.type}">
                                <option value="Fiction" selected>Fiction</option>
                                <option value="Romance">Romance</option>
                                <option value="Mistery">Mistery</option>
                                <option value="Classic">Clasic</option>
                                <option value="Other">Other</option>
                            </select>
                        </span>
                    </p>
                    <input class="button submit" type="submit" value="Save">
                </fieldset>
            </form>
        </section>
        `;

let _router = undefined;
let _renderHandler = undefined;
let _model = undefined;


function initialize(router, renderHandler) {
    _router = router;
    _renderHandler = renderHandler;
}

async function submitHandler(id, e) {
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
            let templateResult = editTemplate(_model);
            alert(errors.join('\n'));
            return _renderHandler(templateResult);
        }

        let book = {
            title,
            description,
            imageUrl,
            type
        }

        await booksService.update(book, id);
        _router.redirect(`/details/${id}`);


    } catch (error) {
        alert(error);
    }



}

async function getView(context) {

    let id = context.params.id;

    let book = await booksService.get(id);
    
    _model = {
        submitHandler,
        book
    }
    let templateResult = editTemplate(_model);
    _renderHandler(templateResult);
}

export default {
    getView,
    initialize
}