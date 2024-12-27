Time Complexity:

Initializing an array: O(1)
Assigning values to array elements: O(n)
Accessing array elements using for loop: O(n)
Accessing array elements using foreach loop: O(n)
Accessing array elements using while loop: O(n)
Accessing array elements using do-while loop: O(n)
Therefore, the overall time complexity of this program is O(n).

Auxiliary space:

Memory allocation for the array: O(n)
Therefore, the auxiliary space complexity of this program is O(n).



# C# Array Methods Cheat Sheet

## Array Initialization
```csharp
// Declaration and Initialization
int[] numbers = new int[5];         // Array of 5 elements
int[] values = { 1, 2, 3, 4, 5 };  // Inline initialization
string[] names = new string[] { "Alice", "Bob" };

# C# Array Cheat Sheet

---

## Common Properties

| **Property**  | **Description**                  | **Example**         |
| ------------- | -------------------------------- | ------------------- |
| `Length`      | Number of elements in the array. | `array.Length`      |
| `Rank`        | Number of dimensions.            | `array.Rank`        |
| `IsFixedSize` | Indicates if the array is fixed. | `array.IsFixedSize` |

---

## Common Methods

| **Method**            | **Description**                                | **Example**                                |
| --------------------- | ---------------------------------------------- | ------------------------------------------ |
| `Array.Sort(array)`   | Sorts the array in ascending order.            | `Array.Sort(numbers);`                     |
| `Array.Reverse()`     | Reverses the order of elements.                | `Array.Reverse(numbers);`                  |
| `Array.IndexOf()`     | Finds the index of the first occurrence.       | `Array.IndexOf(numbers, 3);`               |
| `Array.LastIndexOf()` | Finds the index of the last occurrence.        | `Array.LastIndexOf(numbers, 3);`           |
| `Array.Copy()`        | Copies elements from one array to another.     | `Array.Copy(source, dest, length);`        |
| `Array.Clear()`       | Sets a range of elements to the default value. | `Array.Clear(numbers, 0, numbers.Length);` |
| `Clone()`             | Creates a shallow copy of the array.           | `int[] cloned = (int[])numbers.Clone();`   |
| `GetLength()`         | Gets the number of elements in a dimension.    | `array.GetLength(0);`                      |
| `GetValue()`          | Gets the value at a specific index.            | `array.GetValue(0);`                       |
| `SetValue()`          | Sets a value at a specific index.              | `array.SetValue(10, 0);`                   |

---

## LINQ Methods for Arrays

| **Method**                  | **Description**                                 | **Example**                           |
| --------------------------- | ----------------------------------------------- | ------------------------------------- |
| `array.Select()`            | Projects each element into a new form.          | `numbers.Select(x => x * 2);`         |
| `array.Where()`             | Filters elements based on a condition.          | `numbers.Where(x => x > 2);`          |
| `array.OrderBy()`           | Sorts elements in ascending order.              | `numbers.OrderBy(x => x);`            |
| `array.OrderByDescending()` | Sorts elements in descending order.             | `numbers.OrderByDescending(x => x);`  |
| `array.Aggregate()`         | Applies an accumulator function over the array. | `numbers.Aggregate((x, y) => x + y);` |
| `array.Sum()`               | Computes the sum of the elements.               | `numbers.Sum();`                      |
| `array.Max()`               | Finds the maximum value.                        | `numbers.Max();`                      |
| `array.Min()`               | Finds the minimum value.                        | `numbers.Min();`                      |
| `array.Average()`           | Computes the average of elements.               | `numbers.Average();`                  |
| `array.Distinct()`          | Removes duplicate elements.                     | `numbers.Distinct();`                 |
| `array.ToList()`            | Converts the array to a `List<T>`.              | `numbers.ToList();`                   |

---

## Multidimensional Arrays

```csharp
int[,] matrix = new int[3, 3]; // 2D array
matrix[0, 0] = 1;

// Get dimensions
int rows = matrix.GetLength(0);
int cols = matrix.GetLength(1);

## Jagged Arrays

```csharp
int[][] jaggedArray = new int[3][]; 
jaggedArray[0] = new int[5];
jaggedArray[1] = new int[3];
jaggedArray[2] = new int[2];

// Accessing elements
jaggedArray[0][1] = 42;



## Conversion Methods

| **Method**           | **Description**                        | **Example**                                   |
| -------------------- | -------------------------------------- | --------------------------------------------- |
| `Array.ConvertAll()` | Converts each element to another type. | `Array.ConvertAll(array, x => x.ToString());` |
| `ToArray()`          | Converts a collection to an array.     | `list.ToArray();`                             |

---

## Examples

### Sort and Reverse
```csharp
int[] numbers = { 3, 1, 4, 1, 5 };
Array.Sort(numbers);   // {1, 1, 3, 4, 5}
Array.Reverse(numbers); // {5, 4, 3, 1, 1}


### Find Index
```csharp
int index = Array.IndexOf(numbers, 4); // Returns index of 4


### LINQ Example
```csharp
var evens = numbers.Where(x => x % 2 == 0).ToArray();