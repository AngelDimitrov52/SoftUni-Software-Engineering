
import {html} from './../node_modules/lit-html/lit-html.js';
import carService from '../services/carService.js';

let allCarsTemplate = (cars) => html`
  <!-- All Listings Page -->
<section id="car-listings">
    <h1>Car Listings</h1>
    <div class="listings">

        <!-- Display all records -->
   ${cars.length > 0
? cars.map(x => carTemplate(x)) 
: html`<p class="no-cars">No cars in database.</p>`}
    </div>
</section>`;

let carTemplate = (car) => html`
<div class="listing">
            <div class="preview">
                <img src="${car.imageUrl}">
            </div>
            <h2>${car.brand} ${car.model}</h2>
            <div class="info">
                <div class="data-info">
                    <h3>Year: ${car.year}</h3>
                    <h3>Price: ${car.price} $</h3>
                </div>
                <div class="data-buttons">
                    <a href="/details/${car._id}" class="button-carDetails">Details</a>
                </div>
            </div>
        </div>
`;

let _router = undefined;
let _renderHandler = undefined;

function initialize(router, renderHandler) {
    _router = router;
    _renderHandler = renderHandler;
}


async function getView() {
let cars = await carService.getAllCars();

    let templateResult = allCarsTemplate(cars);
    _renderHandler(templateResult);
}

export default {
    getView,
    initialize
}