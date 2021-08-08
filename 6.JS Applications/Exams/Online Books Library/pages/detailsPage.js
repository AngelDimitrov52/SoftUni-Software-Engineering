import authService from '../services/authService.js';
import { html } from './../node_modules/lit-html/lit-html.js';
import booksService from '../services/booksService.js';

let detailsCarTemplate = (model) => html` 
    <!-- Details Page ( for Guests and Users ) -->
    <section id="details-page" class="details">
        <div class="book-information">
            <h3>${model.book.title}</h3>
            <p class="type">Type: ${model.book.type}</p>
            <p class="img"><img src="${model.book.imageUrl}"></p>
            <div class="actions">
                ${model.isAutor
                ? html`
                <!-- Edit/Delete buttons ( Only for creator of this book )  -->
                <a class="button" href="/edit/${model.book._id}">Edit</a>
                <a class="button" href="#" @click=${(e) => model.deleteHandler(model.book._id, e)}>Delete</a>`
                 : ''}
    
                ${!model.islogged || model.isAutor
                ? ''
                : html`
                <!-- Bonus -->
                <!-- Like button ( Only for logged-in users, which is not creators of the current book ) -->
                <a class="button" href="#">Like</a> `}

                
                <div class="likes">
                    <img class="hearts" src="/images/heart.png">
                    <span id="total-likes">Likes: 0</span>
                </div>
            </div>
        </div>
        <div class="book-description">
            <h3>Description:</h3>
            <p>${model.book.description}</p>
        </div>
    </section>
        `;

let _router = undefined;
let _renderHandler = undefined;

function initialize(router, renderHandler) {
    _router = router;
    _renderHandler = renderHandler;
}

async function deleteHandler(id, e) {
    let confirms = confirm("Are you sure you want to delete this book?")
    if (confirms) {
        await booksService.deleteBook(id);
        _router.redirect('/dashboard');
    }

}

async function getView(context) {
    let id = context.params.id;
    let book = await booksService.get(id);

    let user = authService.getUser();

    let isAutor = false;

    if (user !== undefined && user._id === book._ownerId) {
        isAutor = true;
    }

    let islogged = true;
    if (user == undefined) {
        islogged = false;
    }

    let model = {
        islogged,
        book,
        isAutor,
        deleteHandler
    }

    let templateResult = detailsCarTemplate(model);
    _renderHandler(templateResult);
}

export default {
    getView,
    initialize
}