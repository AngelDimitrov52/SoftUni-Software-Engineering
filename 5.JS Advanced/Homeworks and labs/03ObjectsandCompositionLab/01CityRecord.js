function createCity(cityName, cityPopulation, cityTreasury) {
    const city = {
        name: cityName,
        population: cityPopulation,
        treasury: cityTreasury
    }
    return city;
}
createCity('Tortuga',
    7000,
    15000
);