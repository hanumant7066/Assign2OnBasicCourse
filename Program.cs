using System;
using System.IO;

namespace Assign2OnBasicCourse
{
    class Program
    {
        /*
         * Problem Statement: Write a sample paragraph in a text file. 
         * Write a C# code to take a string input from the user and find the occurrence
         * of the input string in the Sample file. Print the line number of the 2nd instance
         * of that string from the file on the console. 
         */

        public static void GetLineNumber(string[] arr, string input)
        {
            int cnt = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Contains(input))
                {

                    cnt++;
                    if (cnt == 1)
                    {
                        int lastindex = arr[i].IndexOf(input) + input.Length;
                        if (arr[i].Substring(lastindex).Contains(input))
                        {
                            cnt++;
                            Console.WriteLine("{0} present in Line no: {1}", input, i + 1);
                            break;
                        }
                    }

                    if (cnt == 2)
                    {
                        Console.WriteLine("{0} present in Line no: {1}", input, i + 1);
                        break;
                    }
                }
            }
            if (cnt != 2)
            {
                Console.WriteLine("{0} Does not found in file ", input);
            }
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a string to find Line no. of its second Occurance from Txt file ");

            string input = Console.ReadLine();

            if(input.Trim() == "")
            {
                Console.WriteLine("Please Enter Something to search : white space not allowed");
            }
            else
            {
                var path = @"C:\Users\godseh\OneDrive - Lenze SE\Desktop\C#_Training\Assignments_By_Lenze\MyFileAssign2.txt";

                string[] arr = File.ReadAllLines(path);
                
                GetLineNumber(arr, input.Trim());
            }



        }
    }
}
