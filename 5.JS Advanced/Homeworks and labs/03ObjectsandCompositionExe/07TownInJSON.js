function creteTown(array) {
    let result = [];

    for (let index = 1; index < array.length; index++) {

        const [currTown, currLatitude, currLongtitude] =
            array[index].split('|').filter(el => el !== '').map(x => x.trim());

            result.push({
            Town: currTown,
            Latitude: Number(Number(currLatitude).toFixed(2)),
            Longitude: Number(Number(currLongtitude).toFixed(2))
        })
    }

    console.log(JSON.stringify(result));

}
creteTown(['| Town | Latitude | Longitude |',
    '| Sofia | 42.696552 | 23.32601 |',
    '| Beijing | 39.913818 | 116.363625 |']
);