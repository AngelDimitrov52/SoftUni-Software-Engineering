import { requestJSON } from "../helpers/requestJSON.js";



let baseURL = 'http://localhost:3030/data/books';

async function getAll() {

    let resultAll = await requestJSON(baseURL)

    return resultAll;

}

async function  get(id) {

    let resultOne = await requestJSON(`${baseURL}/${id}`);

    return resultOne;

}

async function create(model) {

    let createResult = await requestJSON(`${baseURL}`, 'Post', model, true);

    return createResult

}

async function update(model, ID){

    let updateResult = await requestJSON(`${baseURL}/${ID}`, 'Put', model, true);

    return updateResult

}

async function deleteBook(ID) {

    let deleteResult = await requestJSON(`${baseURL}/${ID}`, 'Delete', undefined, true);

    return deleteResult;

}

async function getAllBooks() {

    let allCarsResult = await requestJSON(`${baseURL}?sortBy=_createdOn%20desc`);

    return allCarsResult;

}

async function getMyBooks(userId)   {

    let myCarsResult = await requestJSON(`${baseURL}?where=_ownerId%3D%22${userId}%22&sortBy=_createdOn%20desc`);

    return myCarsResult;

}

export default {
    getMyBooks,
    getAll,
    get,
    create,
    update,
    deleteBook,
    getAllBooks
}