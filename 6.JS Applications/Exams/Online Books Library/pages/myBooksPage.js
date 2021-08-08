import authService from '../services/authService.js';
import booksService from '../services/booksService.js';
import { html } from './../node_modules/lit-html/lit-html.js';

let myBooksTemplate = (books) => html`
  <!-- My Books Page ( Only for logged-in users ) -->
  <section id="my-books-page" class="my-books">
            <h1>My Books</h1>
            <!-- Display ul: with list-items for every user's books (if any) -->
            ${books.length > 0
            ? html`
             <ul class="my-books-list">
               ${books.map(x =>bookTemplate(x))}
               </ul>`
               : html`  <!-- Display paragraph: If the user doesn't have his own books  -->
            <p class="no-books">No books in database!</p>` }
        </section>`;

let bookTemplate = (book) => html`
 <li class="otherBooks">
                    <h3>${book.title}</h3>
                    <p>Type: ${book.type}</p>
                    <p class="img"><img src="${book.imageUrl}"></p>
                    <a class="button" href="/details/${book._id}">Details</a>
                </li>
`;

let _router = undefined;
let _renderHandler = undefined;

function initialize(router, renderHandler) {
    _router = router;
    _renderHandler = renderHandler;
}


async function getView() {

    let user = authService.getUser();

    let id = user._id;
let books = await booksService.getMyBooks(id);

    let templateResult = myBooksTemplate(books);
    _renderHandler(templateResult);
}

export default {
    getView,
    initialize
}