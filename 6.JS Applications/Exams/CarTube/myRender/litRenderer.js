import { render } from "./../node_modules/lit-html/lit-html.js";


export class LitRender {
   
    constructor() { }

    createRenderHandler(element) {

        return function (template) {
            
            render(template, element);
        }

    }
}