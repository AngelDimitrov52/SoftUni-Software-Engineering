import { html } from './../node_modules/lit-html/lit-html.js';
import carService from '../services/carService.js';


let createTemplate = (form) => html`
<!-- Create Listing Page -->
<section id="create-listing">
    <div class="container">
        <form @submit=${form.submitHandler} id="create-form">
            <h1>Create Car Listing</h1>
            <p>Please fill in this form to create an listing.</p>
            <hr>

            <p>Car Brand</p>
            <input type="text" placeholder="Enter Car Brand" name="brand">

            <p>Car Model</p>
            <input type="text" placeholder="Enter Car Model" name="model">

            <p>Description</p>
            <input type="text" placeholder="Enter Description" name="description">

            <p>Car Year</p>
            <input type="number" placeholder="Enter Car Year" name="year">

            <p>Car Image</p>
            <input type="text" placeholder="Enter Car Image" name="imageUrl">

            <p>Car Price</p>
            <input type="number" placeholder="Enter Car Price" name="price">

            <hr>
            <input type="submit" class="registerbtn" value="Create Listing">
        </form>
    </div>
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

        let brand = formData.get('brand');
        let model = formData.get('model');
        let description = formData.get('description');
        let year = Number(formData.get('year'));
        let imageUrl = formData.get('imageUrl');
        let price = Number(formData.get('price'));


        if (brand.trim() == '') {
            errors.push('Brand is required!')
        }
        if (model.trim() == '') {
            errors.push('Model is required!')
        }
        if (description.trim() == '') {
            errors.push('Description is required!')
        }
        if (year == '' || year < 0) {
            errors.push('Year is required!')

        }

        if (imageUrl.trim() == '') {
            errors.push('ImageUrl is required!')
        }
        if (price == '' || price < 0) {
            errors.push('Price is required!')
        }


        if (errors.length > 0) {
            let templateResult = createTemplate(_form);
            alert(errors.join('\n'));
            return _renderHandler(templateResult);
        }

        let car = {
            brand,
            model,
            description,
            year,
            imageUrl,
            price
        }

        await carService.create(car);
        _router.redirect('/all-listings');


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