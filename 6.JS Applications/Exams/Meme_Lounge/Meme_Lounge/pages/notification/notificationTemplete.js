import { html } from "./../../node_modules/lit-html/lit-html.js";

export let notificationTemplate = (message) => html`
<div id="errorBox" class="notification">
    <span>${message}</span>
</div>`;