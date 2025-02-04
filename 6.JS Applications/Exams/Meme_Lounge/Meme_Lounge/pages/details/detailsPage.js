import authService from "../../services/authService.js";
import { detailsTemplate } from "./detailsTemplate.js";

let _router = undefined;
let _renderHandler = undefined;
let _memesService = undefined;


function initialize(router, renderHandler, memesService) {
    _router = router;
    _renderHandler = renderHandler;
    _memesService = memesService;
}
async function deleteHandler(id, e) {
    try {
        await _memesService.deleteItem(id);
        _router.redirect('/all-memes');
    } catch (error) {
        alert(error);
    }

}

async function getView(context) {
    let id = context.params.id;
    let meme = await _memesService.get(id);
    let user = authService.getUser(id);
    let isOwner = false;
    if(user !== undefined && user._id === meme._ownerId){
        isOwner = true;
    }
    let model = {
        meme,
        deleteHandler,
        isOwner
    };
    let templateResult = detailsTemplate(model);
    _renderHandler(templateResult);
}

export default {
    getView,
    initialize
}