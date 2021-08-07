import carService from '../services/carService.js';
import { html } from './../node_modules/lit-html/lit-html.js';

let searchTemplate = (onChange, onSearch, cars ) => html`  
    <!-- Search Page -->
    <section id="search-cars">
        <h1>Filter by year</h1>
    
        <div class="container">
            <input id="search-input" type="text" name="search" placeholder="Enter desired production year"
                @input=${onChange}>
            <button class="button-list" @click=${onSearch}>Search</button>
        </div>
    
        <h2>Results:</h2>
        <div class="listings">
            ${cars.length > 0
                ?cars.map(x => carTemplate(x))
                 : html` <p class="no-cars"> No results.</p>`}
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
    let searchYear = '';

    function onChange(e) {
        searchYear = e.target.value;
    }
   async function onSearch() {
        let year = Number(searchYear);
        let cars = await carService.search(year);
        let templateResult = searchTemplate(onChange , onSearch , cars);
    _renderHandler(templateResult);
    }

    let templateResult = searchTemplate(onChange , onSearch , []);
    _renderHandler(templateResult);

}
export default {
    getView,
    initialize
}