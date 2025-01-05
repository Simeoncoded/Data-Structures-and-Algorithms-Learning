//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;

class Program
{

    static void Main()
    {

        // printing alternate values
        int[] arr = { 10, 20, 30, 40, 50 };

        for (int i = 0; i < arr.Length; i += 2)
        {
            Console.WriteLine(arr[i] + " ");
         
        }
    }
}