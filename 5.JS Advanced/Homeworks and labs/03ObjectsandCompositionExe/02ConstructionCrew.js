function crew(obg) {

    if (obg.dizziness) {
        obg.levelOfHydrated += obg.weight * 0.1 * obg.experience;
        obg.dizziness = false;
    }
    return obg;

}

console.log(crew({
    weight: 80,
    experience: 1,
    levelOfHydrated: 0,
    dizziness: true
}

));