function rangeBitwiseAnd(m, n) {
    let shift = 0;
    while (m < n) {
        m >>= 1;
        n >>= 1;
    }
}