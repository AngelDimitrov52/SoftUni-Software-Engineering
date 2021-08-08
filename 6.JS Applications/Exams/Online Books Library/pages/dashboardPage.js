import { html } from './../node_modules/lit-html/lit-html.js';
import booksService from '../services/booksService.js';

let allBooksTemplate = (books) => html`
        <!-- Dashboard Page ( for Guests and Users ) -->
        <section id="dashboard-page" class="dashboard">
            <h1>Dashboard</h1>
            <!-- Display ul: with list-items for All books (If any) -->
            ${books.length > 0
        ? html` <ul class="other-books-list">
                ${books.map(x => bookTemplate(x))}
                </li>
            </ul>`
        : html` <p class="no-books">No books in database!</p>`}
        
        </section>
`;

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
    let books = await booksService.getAllBooks();

    let templateResult = allBooksTemplate(books);
    _renderHandler(templateResult);
}

export default {
    getView,
    initialize
}