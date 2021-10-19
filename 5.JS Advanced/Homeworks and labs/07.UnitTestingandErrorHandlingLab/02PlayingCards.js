function createCard(face, suit) {
    let allFaces = ['2', '3', '4', '5', '6', '7', '8', '9', '10', 'J', 'Q', 'K', 'A'];
    let allSuits = {
        S: '\u2660',
        H: '\u2665',
        D: '\u2666',
        C: '\u2663',
    };
    face = face.toUpperCase();
    suit = suit.toUpperCase();
    if (!allFaces.includes(face) || allSuits.hasOwnProperty(suit) === false) {

        throw new Error('Error');
    }

    let resultObj = {
        face,
        suit,
        toString: () => {
            return face + allSuits[suit];
        }
    }
    return resultObj;
}

console.log(createCard('A', 'S').toString());