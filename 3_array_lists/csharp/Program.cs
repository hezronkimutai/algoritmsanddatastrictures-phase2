
using System;

namespace arrayLists
{
    class arrayListsCLass
    {
        public static void Main()
        {
            // One Dimensional Array
            string[] weekDays = new string[] { "Monday", "Teusday", "Wed", "Thur", "Fri", "Sat", "Sun", };

            foreach (string day in weekDays)
            {
                Console.WriteLine(day);
            }



            // Two-dimensional array
            int[,] intarray = new int[,] { { 1, 2 },
                                         { 3, 4 },
                                         { 5, 6 },
                                         { 7, 8 } };

            // The same array with dimensions 
            // specified 4 row and 2 column.
            int[,] intarray_d = new int[4, 2] { { 1, 2 }, { 3, 4 },
                                             { 5, 6 }, { 7, 8 } };

            // A similar array with string elements.
            string[,] str = new string[4, 2] { { "one", "two" },
                                            { "three", "four" },
                                            { "five", "six" },
                                            { "seven", "eight" } };

            // Three-dimensional array.
            int[,,] intarray3D = new int[,,] { { { 1, 2, 3 },
                                             { 4, 5, 6 } },
                                             { { 7, 8, 9 },
                                           { 10, 11, 12 } } };


            // The same array with dimensions 
            // specified 2, 2 and 3.
            int[,,] intarray3Dd = new int[2, 2, 3] { { { 1, 2, 3 },
                                                  { 4, 5, 6 } },
                                                  { { 7, 8, 9 },
                                                { 10, 11, 12 } } };

            // Accessing array elements.
            Console.WriteLine("2DArray[0][0] : " + intarray[0, 0]);
            Console.WriteLine("2DArray[0][1] : " + intarray[0, 1]);
            Console.WriteLine("2DArray[1][1] : " + intarray[1, 1]);
            Console.WriteLine("2DArray[2][0] " + intarray[2, 0]);

            Console.WriteLine("2DArray[1][1] (other) : "
                                     + intarray_d[1, 1]);

            Console.WriteLine("2DArray[1][0] (other)"
                                 + intarray_d[1, 0]);

            Console.WriteLine("3DArray[1][0][1] : "
                               + intarray3D[1, 0, 1]);

            Console.WriteLine("3DArray[1][1][2] : "
                              + intarray3D[1, 1, 2]);

            Console.WriteLine("3DArray[0][1][1] (other): "
                                 + intarray3Dd[0, 1, 1]);

            Console.WriteLine("3DArray[1][0][2] (other): "
                                 + intarray3Dd[1, 0, 2]);

            // using nested loop show string elements
            Console.WriteLine("To String element");
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 2; j++)
                    Console.Write(str[i, j] + " ");





            // JAGGED ARRAYS 
            // An array whose elements are arrays is known as 
            // Jagged arrays it means “array of arrays“. 
            // The jagged array elements may be of different dimensions and sizes.
            //  Below are the examples to show how to declare, 
            //  initialize, and access the jagged arrays.
            /*----------2D Array---------------*/
            // Declare the array of two elements:
            int[][] arr = new int[2][];

            // Initialize the elements:
            arr[0] = new int[5] { 1, 3, 5, 7, 9 };
            arr[1] = new int[4] { 2, 4, 6, 8 };

            // Another way of Declare and
            // Initialize of elements
            int[][] arr1 = { new int[] { 1, 3, 5, 7, 9 },
                         new int[] { 2, 4, 6, 8 } };

            // Display the array elements:
            for (int i = 0; i < arr.Length; i++)
            {
                System.Console.Write("Element [" + i + "] Array: ");
                for (int j = 0; j < arr[i].Length; j++)
                    Console.Write(arr[i][j] + " ");
                Console.WriteLine();
            }
        }
    }
}
