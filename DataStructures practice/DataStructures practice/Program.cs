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


        ////Bonus challenge solution
        //int[] arr = { -10, 0, 15, -20, 15,15 };

        //// Handle empty array
        //if (arr.Length == 0)
        //{
        //    Console.WriteLine("The array is empty. No largest element found.");
        //    return;
        //}

        //int max = arr[0];
        //int count = 0;

        //for (int i = 1; i < arr.Length; i++) 
        //{ 
        //    if (arr[i] > max)
        //    {
        //        max = arr[i];

        //        count = 1;
        //    }else if (arr[i] == max)
        //    {
        //        count++;
        //    }
        //}

        //Console.WriteLine("Largest element " + max);
        //Console.WriteLine("Count of largest element " + count);



        /////PROBLEM FOUR
        //// SECOND LARGEST ELEMENT IN AN ARRAY

        //int[] arr = { 12, 35, 1, 10, 34, 1 };

        //int largest = -1; int secondLargest = -1;

        //// finding the second largest element
        //for (int i = 0; i < arr.Length; i++) 
        //{

        //    // If arr[i] > largest, update second largest with
        //    // largest and largest with arr[i]
        //    if (arr[i] > largest)
        //    {
        //        secondLargest = largest;
        //        largest = arr[i];
        //    }  // If arr[i] < largest and arr[i] > second largest, 
        //    // update second largest with arr[i]
        //    else if (arr[i] <
        //    largest && arr[i] > secondLargest)
        //    {
        //        secondLargest = arr[i];

        //    }
        //}

        //if(secondLargest == -1)
        //{
        //    Console.WriteLine("No largest element found");
        //}
        //else
        //{
        //    Console.WriteLine("Second largest element " + secondLargest);
        //}


        /////PROBLEM FIVE
        ////LARGEST THREE DISTINCT ELEMENTS IN AN ARRAY

        ////Efficient solution, One traversal
        //int[] arr = { 12, 13, 1, 10, 34, 1 };

        //int fst = int.MinValue, sec = int.MinValue, thd = int.MinValue;

        //foreach (int x in arr)
        //{
        //    if (x > fst)
        //    {
        //        thd = sec;
        //        sec = fst;
        //        fst = x;
        //    }
        //    else if (x > sec && x != fst)
        //    {
        //        thd = sec;
        //        sec = x;
        //    }
        //    else if (x > thd && x != sec && x != fst)
        //    {
        //        thd = x;
        //    }
        //}

        //List<int> res = new List<int>();

        //if (fst != int.MinValue) res.Add(fst);
        //if (sec != int.MinValue) res.Add(sec);
        //if (thd != int.MinValue) res.Add(thd);

        //// Output the result
        //foreach (var num in res)
        //{
        //    Console.WriteLine(num);
        //}

        ///PROBLEM SIX
        ///LEADERS IN AN ARRAY
        int[] arr = { 16, 17, 4, 3, 5, 2 };

        int n = arr.Length;

        int maxRight = arr[n - 1];

        List<int> res = new List<int>();

        res.Add(maxRight);

        for(int i = n - 2; i >= 0; i--)
        {
            if(arr[i] > maxRight)
            {
                maxRight = arr[i];
                res.Add(maxRight);
            }
        }

        res.Reverse();

        foreach (int i in res)
        {
            Console.WriteLine(i);
        }
        #endregion
    }
}