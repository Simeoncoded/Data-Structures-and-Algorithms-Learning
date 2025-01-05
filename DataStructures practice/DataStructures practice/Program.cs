﻿//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;

class Program
{

    static void Main()
    {
        #region BASIC PROBLEMS ON ARRAY

        // printing alternate values  
        //int[] arr = { 10, 20, 30, 40, 50 };

        //for (int i = 0; i < arr.Length; i += 2)
        //{
        //    Console.WriteLine(arr[i] + " ");

        //}


        //LINEAR SEARCH ALGORITHM

        //In Linear Search, we iterate over all the elements of the array and check if it 
        //the current element is equal to the target element.If we find any element to be 
        //equal to the target element, then return the index of the current element.Otherwise, 
        //if no element is equal to the target element, then return -1 as the element is not found.
        // Linear search is also known as sequential search.

        //For example: Consider the array arr[] = { 10, 50, 30, 70, 80, 20, 90, 40 } and key = 30

        int[] arrL = { 10, 20, 30, 70, 80, 20, 90, 40 };

        int key = 30;

        bool found = false;


        for (int i = 0; i < arrL.Length; i++)
        {
            if (arrL[i] == key)
            {
                //return i;
                Console.WriteLine(i);
                found = true;
            }
        }
        if (!found)
        {
            //return -1;
            Console.WriteLine("Key not found");
        }
        #endregion
    }
}