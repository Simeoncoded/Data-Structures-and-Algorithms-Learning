//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;

class Program
{

    static void Main()
    {
        #region BASIC PROBLEMS ON ARRAY

        ///PROBLEM ONE
        // PRINTING ALTERNATE VALUES EXAMPLE
        //int[] arr = { 10, 20, 30, 40, 50 };

        //for (int i = 0; i < arr.Length; i += 2)
        //{
        //    Console.WriteLine(arr[i] + " ");

        //}



        ///PROBLEM TWO
        //LINEAR SEARCH ALGORITHM

        //In Linear Search, we iterate over all the elements of the array and check if it 
        //the current element is equal to the target element.If we find any element to be 
        //equal to the target element, then return the index of the current element.Otherwise, 
        //if no element is equal to the target element, then return -1 as the element is not found.
        // Linear search is also known as sequential search.

        //For example: Consider the array arr[] = { 10, 50, 30, 70, 80, 20, 90, 40 } and key = 30

        //int[] arrL = { 10, 20, 30, 70, 80, 20, 90, 40 };

        //int key = 30;

        //bool found = false;
        //int count = 0;


        //for (int i = 0; i < arrL.Length; i++)
        //{
        //    if (arrL[i] == key)
        //    {
        //        //return i;
        //        Console.WriteLine(i);
        //        found = true;
        //    }
        //}
        //if (!found)
        //{
        //    //return -1;
        //    Console.WriteLine("Key not found");
        //}


        //COMPLEX PROBLEM- SIMEONS SOLUTION(LINEAR SEARCH ALGORITHM)
        //int[] arrX = { 5, 12, 8, 19, 27, 3, 15, 8 };
        //int s = 8;
        //bool found = false;
        //int count = 0;


        //for (int i = 0; i < arrX.Length; i++) {
        //    if (arrX[i] == s) 
        //    {
        //        //return i;
        //    found = true;
        //        Console.Write(i + " ");
        //        count++;

        //        found = true;

        //    }
        //    if (!found)
        //    {
        //        //return -1;
        //        Console.WriteLine("Number not found in the array.");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Count" + count);
        //    }
        //}


        ///PROBLEM THREE
        //LARGEST ELEMENT IN AN ARRAY

        //Iterative Approach
        //int[] arr = { 10, 324, 45, 90, 9808 };

        //int max = arr[0]; //first element is the max from the start

        //for (int i = 1; i < arr.Length; i++) //loop through all elements from the first to determine the max
        //{ 
        //    if(arr[i] > max) //conditions to check largest element 
        //    {
        //      max = arr[i];
        //    }
        //}
        //Console.WriteLine("Largest element " + max);

        ////Other simple way
        ////LIBRARY METHOD

        //int theMax  = arr.Max();

        //Console.WriteLine("Largest element " + theMax);


        //Bonus challenge solution
        int[] arr = { -10, 0, 15, -20, 15,15 };

        // Handle empty array
        if (arr.Length == 0)
        {
            Console.WriteLine("The array is empty. No largest element found.");
            return;
        }

        int max = arr[0];
        int count = 0;

        for (int i = 1; i < arr.Length; i++) 
        { 
            if (arr[i] > max)
            {
                max = arr[i];
               
                count = 1;
            }else if (arr[i] == max)
            {
                count++;
            }
        }

        Console.WriteLine("Largest element " + max);
        Console.WriteLine("Count of largest element " + count);

        #endregion
    }
}