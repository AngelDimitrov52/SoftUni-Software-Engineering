import { LitRender } from "./myRender/litRenderer.js";

import page from './node_modules/page/page.mjs';
import addBookPage from "./pages/addBookPage.js";
import dashboardPage from "./pages/dashboardPage.js";
import detailsPage from "./pages/detailsPage.js";
import editPage from "./pages/editPage.js";
import loginPage from "./pages/loginPage.js";
import myBooksPage from "./pages/myBooksPage.js";
import navPage from "./pages/navPage.js";
import registerPage from "./pages/registerPage.js";

let litRender = new LitRender();

let appElemet = document.getElementById('site-content');
let navElemet = document.getElementById('site-header');


let appRenderHandler = litRender.createRenderHandler(appElemet);
let navRenderHandler = litRender.createRenderHandler(navElemet);

navPage.initialize(page, navRenderHandler);
loginPage.initialize(page, appRenderHandler);
registerPage.initialize(page, appRenderHandler);
dashboardPage.initialize(page, appRenderHandler);
addBookPage.initialize(page, appRenderHandler);
detailsPage.initialize(page, appRenderHandler);
editPage.initialize(page, appRenderHandler);
myBooksPage.initialize(page, appRenderHandler);


page('/', '/dashboard');
page('/index.html', '/dashboard');

page(navPage.getView);

page('/login', loginPage.getView);
page('/register', registerPage.getView);
page('/dashboard', dashboardPage.getView);
page('/add-book', addBookPage.getView);
page('/details/:id', detailsPage.getView);
page('/edit/:id', editPage.getView);
page('/my-books', myBooksPage.getView);

page.start();



