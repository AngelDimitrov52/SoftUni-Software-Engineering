
import { html } from './../node_modules/lit-html/lit-html.js';

let notificationtemplate = (message) => html`
 <div id="errorBox" class="notification">
<span>${message}</span>
</div>`;

let _router = undefined;
let _renderHandler = undefined;


function initialize(router, renderHandler) {
    _router = router;
    _renderHandler = renderHandler;
}



async function getView(message) {
    
    let templateResult = notificationtemplate(message);
    _renderHandler(templateResult);
    setTimeout(()=> _renderHandler(null) , 3000);
    
}

export default {
    getView,
    initialize
}
 