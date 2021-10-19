import { html } from './../node_modules/lit-html/lit-html.js';
import carService from '../services/carService.js';


let editTemplate = (_car) => html`<!-- Edit Listing Page -->
<section id="edit-listing">
    <div class="container">

        <form @submit=${(e)=> _car.submitHandler(_car.car._id, e)} id="edit-form">
            <h1>Edit Car Listing</h1>
            <p>Please fill in this form to edit an listing.</p>
            <hr>

            <p>Car Brand</p>
            <input type="text" placeholder="Enter Car Brand" name="brand" value="${_car.car.brand}">

            <p>Car Model</p>
            <input type="text" placeholder="Enter Car Model" name="model" value="${_car.car.model}">

            <p>Description</p>
            <input type="text" placeholder="Enter Description" name="description" value="${_car.car.description}">

            <p>Car Year</p>
            <input type="number" placeholder="Enter Car Year" name="year" value="${_car.car.year}">

            <p>Car Image</p>
            <input type="text" placeholder="Enter Car Image" name="imageUrl" value="${_car.car.imageUrl}">

            <p>Car Price</p>
            <input type="number" placeholder="Enter Car Price" name="price" value="${_car.car.price}">

            <hr>
            <input type="submit" class="registerbtn" value="Edit Listing">
        </form>
    </div>
</section>`;

let _router = undefined;
let _renderHandler = undefined;
let _car = undefined;


function initialize(router, renderHandler) {
    _router = router;
    _renderHandler = renderHandler;
}

async function submitHandler(id, e) {
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
        if (year == '') {
            errors.push('Year is required!')
            if (year < 0) {
                errors.push('Year negative number!')
            }
        }
        if (imageUrl.trim() == '') {
            errors.push('ImageUrl is required!')
        }
        if (price == '') {
            errors.push('Price is required!')
            if (price < 0) {
                errors.push('Price negative number!')
            }
        }


        if (errors.length > 0) {
            let templateResult = editTemplate(_car);
            alert(errors.join('\n'));
            return _renderHandler(templateResult);
        }

         let editCar = {
            brand,
            model,
            description,
            year,
            imageUrl,
            price
        }

        await carService.update(editCar, id);
        _router.redirect('/all-listings');


    } catch (error) {
        alert(error);
    }



}

async function getView(context) {
    let id = context.params.id;
    let car = await carService.get(id);
    
    _car = {
        submitHandler,
        car
    }
    let templateResult = editTemplate(_car);
    _renderHandler(templateResult);
}

export default {
    getView,
    initialize
}