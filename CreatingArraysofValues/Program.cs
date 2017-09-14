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
            //numbers[5] = 42;
            // The variable is only meant to hold 5 items, this doesn't work

            Console.WriteLine(numbers.Length);
                // Find out how many #s are in the array

            /*

            // Shortcut

            int[] numbers = new int[] { 4, 8, 16, 18, 23, 42 };
            // no declaration of number of items, can list more or less


            Console.WriteLine(numbers[1].ToString());
            // retrieve value placed into element of the array
            Console.ReadLine();

            */

            /*

            // Array to Hold Names
            string[] names = new string[] { "Eddie", "Alex", "Michael", "David Lee" };

            foreach (string name in names)
            // iteates through the code block once for each element in the array
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();

            */

            /*

            string zig = "You can get what you want out of life" + 
                "if you help enough other people get what they want.";
			// indentation shows the association with the line above it

			// char stores a single character
			char[] charArray = zig.ToCharArray();
            Array.Reverse(charArray);
            // each element in the array will be reversed (1st to last)

            foreach (char zigChar in charArray)
                Console.Write(zigChar);
            // no need for curly braces because it's one line

            Console.ReadLine();


            */


            // To Declare Array
                // Define the data type and add opening/closing square brackets
                // Declare the size of the array, or give it the actual items
            // Use square bracket to access parts of the array
                // To assign or retrieve a value
            // Arrays are always 0 BASED
                // Outside the boundry (# of elements) will cause an acception


        }
    }
}
