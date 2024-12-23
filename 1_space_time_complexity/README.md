## create a new runnable csharp console app
dotnet new console -n csharp


## Resources
- [Big O Cheat Sheet](https://www.bigocheatsheet.com/){:target="_blank"}
- [Halting Problem](https://en.wikipedia.org/wiki/Halting_problem){:target="_blank"}
- [Big O Notation](https://en.wikipedia.org/wiki/Big_O_notation){:target="_blank"}
- [Asymptotic Analysis](https://en.wikipedia.org/wiki/Asymptotic_analysis){:target="_blank"}
- [Polynomial](https://en.wikipedia.org/wiki/Polynomial){:target="_blank"}
- [Stack Overflow: Big O Calculation](https://stackoverflow.com/questions/3255/big-o-how-do-you-calculate-approximate-it){:target="_blank"}





# Finding the time complexity of an algorithmn



Time complexity is a measure of the computational complexity that describes the amount of time an algorithm takes to run as a function of the size of its input. Here’s a step-by-step guide to determine the time complexity of an algorithm:

---

## 1. **Understand the Algorithm**
   - Carefully analyze the algorithm or code.
   - Identify the input size `n`.
   - Determine what the algorithm does with the input (loops, function calls, etc.).

---

## 2. **Identify Basic Operations**
   - Count the most frequently executed operation, such as arithmetic operations, comparisons, data assignments, or function calls.
   - Focus on the part of the code that has the largest impact on the running time.

---

## 3. **Analyze Loops**
   - **Simple Loops**: A loop running `n` times contributes \( O(n) \).
   - **Nested Loops**: Multiply the iterations. For example:
     - A loop inside another loop, each running `n` times, results in \( O(n^2) \).
   - **Logarithmic Loops**: A loop that halves the input size in each iteration contributes \( O(\log n) \).

---

## 4. **Analyze Recursion**
   - Use recurrence relations to model recursive calls.
   - Solve the recurrence using methods like the **Master Theorem** or **Substitution Method**.
   - Example: A recursive algorithm splitting the problem into two halves (like merge sort) often has a complexity of \( O(n \log n) \).

---

## 5. **Consider All Code Blocks**
   - If the algorithm has multiple independent steps, sum their complexities.
     - Example: \( O(n) + O(n^2) \) simplifies to \( O(n^2) \) (higher-order term dominates).
   - For conditional branches (`if`, `else`), analyze the worst-case complexity.

---

## 6. **Drop Constants and Lower-Order Terms**
   - Time complexity focuses on the growth rate, so constants and non-dominant terms can be omitted.
     - Example: \( O(2n + 10) \) simplifies to \( O(n) \).

---

## 7. **Express the Result in Big-O Notation**
   - Big-O notation describes the upper bound of an algorithm’s growth rate.
   - Examples:
     - \( O(1) \): Constant time.
     - \( O(\log n) \): Logarithmic time.
     - \( O(n) \): Linear time.
     - \( O(n^2) \): Quadratic time.

---

## 8. **Verify with Examples**
   - Test the algorithm with various input sizes.
   - Ensure the theoretical complexity matches the observed behavior.

---

## Common Time Complexities
| Notation       | Example Algorithms              | Growth Rate                  |
|----------------|----------------------------------|------------------------------|
| \( O(1) \)     | Accessing an array element      | Constant                     |
| \( O(\log n) \)| Binary search                   | Logarithmic                  |
| \( O(n) \)     | Linear search                   | Linear                       |
| \( O(n \log n) \)| Merge sort, Quick sort (avg)   | Log-linear                   |
| \( O(n^2) \)   | Bubble sort, Selection sort     | Quadratic                    |
| \( O(2^n) \)   | Recursive Fibonacci            | Exponential                  |

---

By following these steps, you can systematically determine the time complexity of any algorithm.



