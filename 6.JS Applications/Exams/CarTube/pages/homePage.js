import {html} from './../node_modules/lit-html/lit-html.js';

let homeTemplate = () => html`
<!-- Welcome Page ( Only for guest users ) -->
<section id="main">
            <div id="welcome-container">
                <h1>Welcome To Car Tube</h1>
                <img class="hero" src="/images/car-png.webp" alt="carIntro">
                <h2>To see all the listings click the link below:</h2>
                <div>
                    <a href="/all-listings" class="button">Listings</a>
                </div>
            </div>
        </section>
`;

let _router = undefined;
let _renderHandler = undefined;

function initialize(router, renderHandler) {
    _router = router;
    _renderHandler = renderHandler;
}


async function getView() {
    let templateResult = homeTemplate();
    _renderHandler(templateResult);
}

export default {
    getView,
    initialize
}