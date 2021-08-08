

import authService from "../services/authService.js";



export async function requestJSON(URL, method, body, isAuthorized, skip) {

    if (method === undefined) {

        method = 'Get'

    }

    let headers = {};

    if (['post', 'put', 'patch'].includes(method.toLowerCase())) {

        headers['Content-Type'] = 'application/json';

    }

    if (isAuthorized) {

        headers['X-Authorization'] = authService.getUser().accessToken;

    }

    let model = {

        headers,
        method

    };

    if (body !== undefined) {

        model.body = JSON.stringify(body);
    }

    let res = await fetch(URL, model)

    if (!res.ok) {

        let mess = await res.text();

        throw new Error(`${res.status}: ${res.statusText}\n${mess}`)

    }

    let requeterResult = undefined;

    if (!skip) {
        requeterResult = await res.json()
    }

    return requeterResult;


}