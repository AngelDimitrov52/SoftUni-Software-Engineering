import { requestJSON } from "../helpers/requestJSON.js";

let baseURL = 'http://localhost:3030/users';

function setUser(user) {

    localStorage.setItem('user', JSON.stringify(user));

}

function getUser() {

    let userResult = localStorage.getItem('user') === null
        ? undefined
        : JSON.parse(localStorage.getItem('user'));

    return userResult;
}

async function login(user) {

    let loginResult = await requestJSON(`${baseURL}/login`, 'Post', user);

    setUser(loginResult);

}


async function register(user) {

    let registerResult = await requestJSON(`${baseURL}/register`, 'Post', user);

    setUser(registerResult);

}

async function logout() {

    await requestJSON(`${baseURL}/logout`, 'Get', undefined, true, true);

    localStorage.clear();

}


export default {
    setUser,
    getUser,
    login,
    register,
    logout
}