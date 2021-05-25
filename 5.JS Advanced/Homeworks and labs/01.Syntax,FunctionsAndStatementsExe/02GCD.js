function GCD(a, b) {
    if (!b) {
        console.log(a);
        return;
    }

    GCD(b, a % b);
}
GCD(15, 5);
GCD(2154, 458);