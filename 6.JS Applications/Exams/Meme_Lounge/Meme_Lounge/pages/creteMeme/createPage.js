import { createTemeple } from "./creteTemplate.js";

let _router = undefined;
let _renderHandler = undefined;
let _memesService = undefined;
let _form = undefined;
let _notification = undefined;

function initialize(router, renderHandler, memesService, notification) {
    _router = router;
    _renderHandler = renderHandler;
    _memesService = memesService;
    _notification = notification;
}

async function submitHandler(e) {
    e.preventDefault();
    try {
        let formData = new FormData(e.target);
        _form.errorMessages = []

        let title = formData.get('title');
        let description = formData.get('description');
        let imageUrl = formData.get('imageUrl');

        if (title.trim() === '') {
            _form.errorMessages.push('Title is required')
        }
        if (description.trim() === '') {
            _form.errorMessages.push('Description is required')
        }
        if (imageUrl.trim() === '') {
            _form.errorMessages.push('ImageUrl is required')
        }

        if (_form.errorMessages.length > 0) {
            let templateResult = createTemeple(_form);
            _notification.getView(_form.errorMessages.join('\n'));
            //alert(_form.errorMessages.join('\n'));
            return _renderHandler(templateResult);

        }

        let user = {
            title,
            description,
            imageUrl
        }

        await _memesService.create(user);
        _router.redirect('/all-memes');

    } catch (err) {
        alert(err);
    }

}

async function getView() {
    _form = {
        submitHandler,
        errorMessages: []
    }
    let templateResult = createTemeple(_form);
    _renderHandler(templateResult);
}

export default {
    getView,
    initialize
}