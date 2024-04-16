```cpp
#include <iostream>

int rangeBitwiseAnd(int m, int n) {
    while(n > m) {
       n = n & n - 1;
    }
    return m & n;
}

int main() {
    int m, n;
    std::cout << "Enter the range (m n): ";
    std::cin >> m >> n;
    std::cout << "Bitwise AND of numbers in range: " << rangeBitwiseAnd(m, n) << std::endl;
    return 0;
}
```