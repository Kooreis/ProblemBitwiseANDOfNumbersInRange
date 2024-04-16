Here is a TypeScript solution for the problem:

```typescript
function rangeBitwiseAnd(m: number, n: number): number {
    let i = 0;
    while (m != n) {
        m >>= 1;
        n >>= 1;
        i++;
    }
    return m << i;
}

console.log(rangeBitwiseAnd(5, 7));
```

This program will output the bitwise AND of all numbers in the range [5, 7].