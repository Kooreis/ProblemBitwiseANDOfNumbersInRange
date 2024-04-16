Here is a JavaScript solution for the problem:

```javascript
function rangeBitwiseAnd(m, n) {
    let shift = 0;
    while (m < n) {
        m >>= 1;
        n >>= 1;
        ++shift;
    }
    return m << shift;
}

console.log(rangeBitwiseAnd(5, 7));
```

This console application takes two numbers as input and returns the bitwise AND of all numbers in this range. It uses a while loop to right shift both numbers until they are equal, then left shifts the result to get the final answer.