import { LitRenderer } from "./rendering/litRenderer.js";

import page from './node_modules/page/page.mjs';
import navigationPage from "./pages/navigationPage.js";
import homePage from "./pages/homePage.js";
import loginPage from "./pages/loginPage.js";
import registerPage from "./pages/registerPage.js";
import allMemePage from "./pages/allMemePage.js";
import detailsMemePage from "./pages/detailsMemePage.js";
import createMemePage from "./pages/createMemePage.js";
import editMemePage from "./pages/editMemePage.js";
import profilePage from "./pages/profilePage.js";
import notification from "./pages/notification.js";




let litRender = new LitRenderer();

let appElemet = document.getElementById('app');
let navElemet = document.getElementById('nav');
let notificationElemet = document.getElementById('notifications');

let appRenderHandler = litRender.createRenderHandler(appElemet);
let navRenderHandler = litRender.createRenderHandler(navElemet);
let notificationRenderHandler = litRender.createRenderHandler(notificationElemet);

navigationPage.initialize(page, navRenderHandler);
homePage.initialize(page, appRenderHandler);
loginPage.initialize(page, appRenderHandler);
registerPage.initialize(page, appRenderHandler);
allMemePage.initialize(page, appRenderHandler);
detailsMemePage.initialize(page, appRenderHandler);
createMemePage.initialize(page, appRenderHandler);
editMemePage.initialize(page, appRenderHandler);
profilePage.initialize(page, appRenderHandler);
notification.initialize(page , notificationRenderHandler);

page('/', '/home');
page('/index.html', '/home');

page(navigationPage.getView);


page('/home' , homePage.getView);
page('/login' , loginPage.getView);
page('/register' , registerPage.getView);
page('/all-memes' , allMemePage.getView);
page('/detail/:id' , detailsMemePage.getView);
page('/create' , createMemePage.getView);
page('/edit/:id' , editMemePage.getView);
page('/profile' , profilePage.getView);

page.start();



