import { html } from "./../node_modules/lit-html/lit-html.js";

export let liTemplate = (town) => html`<li>${town}</li>`;

export let allTownTemplate = (allTowns) => html`
<ul>
    ${allTowns.map(x => liTemplate(x))};
</ul>
`;