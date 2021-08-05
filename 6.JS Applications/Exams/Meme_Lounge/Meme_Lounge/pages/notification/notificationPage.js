
import { notificationTemplate } from "./notificationTemplete.js";


let _router = undefined;
let _renderHandler = undefined;


function initialize(router, renderHandler) {
    _router = router;
    _renderHandler = renderHandler;
}


async function getView(message) {
    let templateResult = notificationTemplate(message);
    _renderHandler(templateResult);
    setTimeout(() => _renderHandler(null) , 3000);
}

export default {
    getView,
    initialize
}