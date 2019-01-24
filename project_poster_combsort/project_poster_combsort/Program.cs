using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_poster_combsort
{
    class Program
    {
        static void Main(string[] args)
        {   
            int n;   //number of element to be sorted
            Console.WriteLine("Comb Sort");  
            Console.WriteLine("enter how many number you want to sort");
            n = Convert.ToInt16(Console.ReadLine());
            int[] arr = new int[n];   
            //take input in the array
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt16(Console.ReadLine());
            }
            //array sent as a arguement to the function combsort 
            //create an object 
            Program p = new Program();
            p.combsort(arr);
            //displaying the array elements after sorting
            Console.WriteLine("Sorted array using comb sort");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
           
        }

        public void combsort(int[] arr)
        {
            double shrinkfactor =1.3;   //gap value will be divided by this shrink factor on every iteration 
            int gapvalue = arr.Length;  //initially the value is the length of the array 
            bool swapped = true;
            //while loop will run until the gapvalue will become 1 and swapped will be false
            while (gapvalue > 1 || swapped)
            { 
                //if gap value is greater than 1 then divide the gap value by shrink factor 
                if (gapvalue > 1)
                {
                    gapvalue = (int)(gapvalue / shrinkfactor); //this will update the value of gap in every iteration
                }

                swapped = false;   //this will checck in the for loop if no swapping will occur then the program will terminate here
                //this means the array is sorted
                for (int i = 0; i + gapvalue < arr.Length; i++)
                {
                    if (arr[i] > arr[i + gapvalue])
                    {
                        int t = arr[i];
                        arr[i] = arr[i + gapvalue];
                        arr[i + gapvalue] = t;
                        swapped = true;
                    }
                }
            }
        }
    }
}

