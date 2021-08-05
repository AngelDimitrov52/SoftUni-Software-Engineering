import { allMemeTelplate } from "./allMemeTemplete.js";

let _router = undefined;
let _renderHandler = undefined;
let _memeService = undefined;


function initialize(router, renderHandler, memeService) {
    _router = router;
    _renderHandler = renderHandler;
    _memeService = memeService;
}

async function getView(context) {

    let allMemes = await _memeService.getAllMemes();
    let templateResult = allMemeTelplate(allMemes);
    _renderHandler(templateResult);
}

export default {
    getView,
    initialize
}