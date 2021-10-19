import authService from "../../services/authService.js";
import { profileTemplete } from "./profileTemplate.js";

let _router = undefined;
let _renderHandler = undefined;
let _memeService = undefined;


function initialize(router, renderHandler, memeService) {
    _router = router;
    _renderHandler = renderHandler;
    _memeService = memeService;
}

async function getView() {
let user = await authService.getUser();

let memes = await _memeService.getMyMemes(user._id);

let model ={
    memes,
    user

};

    let templateResult = profileTemplete(model);
    _renderHandler(templateResult);
}

export default {
    getView,
    initialize
}