using System;
using System.Linq;

namespace Exercise7
{
    class Program
    {  
        static void Main(string[] args)
        {
            
        }

        // #1 Write a method that takes two integers and displays their sum.
        public int sumOfTwoInts(int num1, int num2)
        {
            int sum = num1 + num2;
            return sum;
        }

        // #2 Write a method that takes five doubles and returns their average.

        public double averageOfFiveDoubles(double double1, double double2, 
            double double3, double double4, double double5)
        {
            double average = ( double1 + double2 + double3 + double4 + double5 ) / 5;
            return average;
        }

        // #3 Write a method that returns the sum of two randomly generated integers.

        public int randomIntSum(int rand1, int rand2)
        {
            Random r = new Random();
            rand1 = r.Next();
            rand2 = r.Next();

            int sum = rand1 + rand2;

            return sum;
        }

        // #4 Write a method that takes three integers and returns true if their sum
        //is divisible by 3 and false otherwise.

        public bool divisibleByThree(int num1, int num2, int num3)
        {
            int sum = num1 + num2 + num3;

            if (sum / 3 == 0)
            {
                return true;
            }
            else
                return false;
        }

        // #5 Write a method that takes two strings and displays the string that has fewer characters.

        public void stringWithFewerChars(string s1, string s2)
        {
            if (s1.Length > s2.Length)
            {
                Console.WriteLine(s1);
            } else if (s1.Length < s2.Length)
            {
                Console.WriteLine(s2);
            }

        }

        // #6 Write a method that takes an array of doubles and returns the largest value in the array.
        public double largestValue(double[] a)
        {
            return a.Max();
        }

        // #7 Write a method that generates and returns an array of fifty integer values.

        public int[] intArray()
        {
            
            Random r = new Random();

            int[] arr = new int[50];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = r.Next();
            }
            return arr;
        }

        // #8 Write a method that takes two bool variables and return true if they have the same 
        // value and false otherwise.
        public bool CompareBools(bool b1, bool b2)
        {
            return b1 == b2;
        }
        // #9 Write a method that takes an int and a double and returns their product.
        public double productOfIntAndDouble(int i, double d)
        {
            double sum = i * d;
            return sum;
        }

        // #10 Write a method that takes a two-dimensional array of integers and returns
        // the average of the entries.

        public int averageOfTwoArrays(int[][] arr)
        {
            int sum = 0;
            int totalNumbers = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    sum = sum + arr[i][j];
                    totalNumbers++;
                }
            }

            return sum / totalNumbers;
        }

    }
}
