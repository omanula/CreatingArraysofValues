using System;

namespace CreatingArraysofValues
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // array: bucket that contains others buckets, grouping of data
            // square brackets for arrays!

            int[] numbers = new int[5];
            // square brackets declare an array of type int
            // 5 elements will be in the array
                // CAN NOT expand or shrink the array once it is defined

            // arrays are 0 based: count element of array starting at 0 as 1st element
            numbers[0] = 4;
            numbers[1] = 8;
            // number sub 1 equals the value 8
            // number's array at index 1 equals the value 8
            // the second element of the number's array is equal to value 8
            numbers[2] = 16;
            numbers[3] = 18;
            numbers[4] = 23;
            // individual elements of the array will be set to a value
            // index access operator: square brackets above
            numbers[5] = 42;
            // The variable is only meant to hold 5 items, this doesn't work


            // Shortcut

            int[] numbers = new int[] { 4, 8, 16, 18, 23, 42 };
            // no declaration of number of items, can list more or less


            Console.WriteLine(numbers[1].ToString());
            // retrieve value placed into element of the array
            Console.ReadLine();


            // Array to Hold Names
            string[] names = new string[] { "Eddie", "Alex", "Michael", "David Lee" };

            foreach (string name in names)
            // iteates through the code block once for each element in the array
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();
        }
    }
}
