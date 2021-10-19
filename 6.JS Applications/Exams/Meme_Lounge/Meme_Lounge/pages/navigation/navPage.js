
import { navTemplate } from "./navtemplete.js";

let _router = undefined;
let _renderHandler = undefined;
let _authService = undefined;

function initialize(router, renderHandler, authService) {
    _router = router;
    _renderHandler = renderHandler;
    _authService = authService;

}

async function loguotHandler() {
    await _authService.logout();
    _router.redirect('/home');
}


async function getView(context, next) {
    let user = _authService.getUser()
    let email = user !== undefined ? user.email : undefined;

    let navModel = {
        email,
        isLoggedIn: user !== undefined,
        loguotHandler
    }

    let templateResult = navTemplate(navModel);
    _renderHandler(templateResult);
    next();
}

export default {
    getView,
    initialize
}