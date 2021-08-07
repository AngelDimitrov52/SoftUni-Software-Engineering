import authService from '../services/authService.js';
import {html} from './../node_modules/lit-html/lit-html.js';
import carService from '../services/carService.js';

let detailsCarTemplate = (model) => html` 
 <!-- Listing Details Page -->
 <section id="listing-details">
            <h1>Details</h1>
            <div class="details-info">
                <img src="${model.car.imageUrl}">
                <hr>
                <ul class="listing-props">
                    <li><span>Brand:</span>${model.car.brand}</li>
                    <li><span>Model:</span>${model.car.model}</li>
                    <li><span>Year:</span>${model.car.year}</li>
                    <li><span>Price:</span>${model.car.price}$</li>
                </ul>

                <p class="description-para">${model.car.description}</p>
                    ${model.isAutor
                    ? html` <div class="listings-buttons">
                    <a href="/edit/${model.car._id}" class="button-list">Edit</a>
                    <a href="#" @click=${(e)=> model.deleteHandler(model.car._id, e)} class="button-list">Delete</a>
                </div>`
                : ''}
            </div>
        </section>`;

let _router = undefined;
let _renderHandler = undefined;

function initialize(router, renderHandler) {
    _router = router;
    _renderHandler = renderHandler;
}

async function deleteHandler(id, e) {
    let confirms = confirm("Are you sure you want to delete car?")
    if (confirms) {
        await carService.deleteItem(id);
        _router.redirect('/all-listings');
    }

}

async function getView(context) {
    let id = context.params.id;
    let car = await carService.get(id);

    let user =  authService.getUser();

    let isAutor = false;

    if (user !== undefined && user._id === car._ownerId) {
        isAutor = true;
    }


    let model = {
        car,
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