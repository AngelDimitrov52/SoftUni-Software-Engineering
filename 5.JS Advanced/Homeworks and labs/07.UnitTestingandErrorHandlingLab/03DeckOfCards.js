function printDeckOfCards(cards) {
    let result = [];
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

            console.log(`Invalid card: ${face}${suit}`);
            return;
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
    cards.forEach(el => {
        let face = el.substring(0, el.length - 1);
        let suit = el.substring(el.length - 1);
        let newCard = createCard(face, suit);

        result.push(newCard);
    });

    console.log(result.join(' '));
}



printDeckOfCards(['5S', '3D', 'QD', '1C']);
