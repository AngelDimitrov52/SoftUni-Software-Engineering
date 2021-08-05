import { LitRenderer } from "./rendering/litRenderer.js";

import page from "./node_modules/page/page.mjs";
import homePage from "./pages/home/homePage.js";
import authService from "./services/authService.js";
import navPage from "./pages/navigation/navPage.js";
import registerPage from "./pages/register/registerPage.js";
import loginPage from "./pages/login/loginPage.js";
import allMemePage from "./pages/allMemes/allMemePage.js";
import memesService from "./services/memesService.js";
import createPage from "./pages/creteMeme/createPage.js";
import detailsPage from "./pages/details/detailsPage.js";
import editMemePage from "./pages/editMeme/editMemePage.js";
import profilePage from "./pages/profile/profilePage.js";
import notificationPage from "./pages/notification/notificationPage.js";

let navElemet = document.getElementById('nav');
let appElemet = document.getElementById('app');
let notificationEleet = document.getElementById('notifications');

let renderer = new LitRenderer();

let navRenderHandler = renderer.createRenderHandler(navElemet);
let appRenderHandler = renderer.createRenderHandler(appElemet);
let notificationtHandler = renderer.createRenderHandler(notificationEleet);

notificationPage.initialize(page, notificationtHandler);

navPage.initialize(page, navRenderHandler, authService);
homePage.initialize(page, appRenderHandler, authService);
loginPage.initialize(page, appRenderHandler, authService, notificationPage);
registerPage.initialize(page, appRenderHandler, authService, notificationPage);
allMemePage.initialize(page, appRenderHandler, memesService);
createPage.initialize(page, appRenderHandler, memesService, notificationPage);
detailsPage.initialize(page, appRenderHandler, memesService);
editMemePage.initialize(page, appRenderHandler, memesService, notificationPage);
profilePage.initialize(page, appRenderHandler, memesService);


page('/index.html', '/home');
page('/', '/home');

page(navPage.getView);

page('/home', homePage.getView);
page('/login', loginPage.getView);
page('/register', registerPage.getView);
page('/all-memes', allMemePage.getView);
page('/create', createPage.getView);
page('/details/:id', detailsPage.getView);
page('/edit/:id', editMemePage.getView);
page('/profile', profilePage.getView);

page.start();

