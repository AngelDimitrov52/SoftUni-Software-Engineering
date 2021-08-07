import { LitRenderer } from "./rendering/litRenderer.js";

import page from './node_modules/page/page.mjs';
import navPage from "./pages/navPage.js";
import homePage from "./pages/homePage.js";
import loginPage from "./pages/loginPage.js";
import registerPage from "./pages/registerPage.js";
import allCarsPage from "./pages/allCarsPage.js";
import createPage from "./pages/createPage.js";
import detailsPage from "./pages/detailsPage.js";
import editPage from "./pages/editPage.js";
import myListingPage from "./pages/myListingPage.js";
import searchingPage from "./pages/searchingPage.js";

let litRender = new LitRenderer();

let appElemet = document.getElementById('site-content');
let navElemet = document.getElementById('nav');


let appRenderHandler = litRender.createRenderHandler(appElemet);
let navRenderHandler = litRender.createRenderHandler(navElemet);

navPage.initialize(page, navRenderHandler);
homePage.initialize(page, appRenderHandler);
loginPage.initialize(page, appRenderHandler);
registerPage.initialize(page, appRenderHandler);
allCarsPage.initialize(page, appRenderHandler);
createPage.initialize(page, appRenderHandler);
detailsPage.initialize(page, appRenderHandler);
editPage.initialize(page, appRenderHandler);
myListingPage.initialize(page, appRenderHandler);
searchingPage.initialize(page, appRenderHandler);

page('/', '/home');
page('/index.html', '/home');

page(navPage.getView);

page('/home' , homePage.getView);
page('/login' , loginPage.getView);
page('/register' , registerPage.getView);
page('/all-listings' , allCarsPage.getView);
page('/create' , createPage.getView);
page('/details/:id' , detailsPage.getView);
page('/edit/:id' , editPage.getView);
page('/my-listings' , myListingPage.getView);
page('/by-year' , searchingPage.getView);



page.start();



