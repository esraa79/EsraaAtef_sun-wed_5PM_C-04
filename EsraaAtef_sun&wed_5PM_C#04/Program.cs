using System.ComponentModel;
using System.Drawing;
using System.Globalization;

namespace Assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //------------Arrays----------
            #region Q1
            //            1 - .Write a program that prints an identity matrix using for
            //loop, in other words takes a value n from the user and shows the
            //identity table of size n * n.

            //Console.WriteLine( "Enter Size number:");
            //int Matrixsize = int.Parse( Console.ReadLine() );
            //for( int i = 0; i < Matrixsize; i++ )
            //{
            //    for( int j = 0; j < Matrixsize; j++ )
            //    {
            //        if (i == j)
            //            Console.Write("1");
            //        else
            //            Console.Write("0");
            //    }
            //    Console.WriteLine("");

            //}
            //Console.Read();
            #endregion

            #region Q2
            //            Write a program in C# Sharp to find the sum of all elements
            //              of the array.
            //Console.WriteLine( "Enter the size of the array");
            //int size= int.Parse( Console.ReadLine() );
            //int[] numbers = new int[size];
            //int sum = 0;
            //for (int i = 0; i < size; i++)
            //{
            //    Console.WriteLine($"Enter Number {i+1}");
            //   numbers[i] = int.Parse(Console.ReadLine());  
            //}
            ////get sum
            //for (int i = 0; i < size; i++)
            //{
            //    sum += numbers[i];
            //}
            //Console.WriteLine($"the Sum of the array : {sum}");

            #endregion

            #region Q3
            //Write a program in C# Sharp to merge two arrays of the same
            //size sorted in ascending order.

            //int[] arr1 = { 1, 8, 3 };
            //int[] arr2 = { 7,2,6 };

            ////int[] arr3 = arr1.Concat(arr2).ToArray();
            ////or
            //int[] MergedArr = new int[arr1.Length+arr2.Length];
            //for(int i = 0; i < arr1.Length; i++)
            //{
            //    MergedArr[i] = arr1[i];
            //}
            //for (int i = 0; i < arr2.Length; i++)
            //{
            //    MergedArr[arr1.Length+i] = arr2[i];
            //}
            //Console.WriteLine($"Array After Merg: {string.Join(",", MergedArr)}");


            //Array.Sort(MergedArr);

            //Console.WriteLine($"Sorted Array : {string.Join(",", MergedArr)}");



            #endregion

            #region Q4
            //            Write a program in C# Sharp to count the frequency of each
            //            element of an array.

            //int[] numbers = { 1, 2, 4, 2, 4, 5, 5, 4, 5, 5 };

            //Dictionary<int, int> FreqDic = new Dictionary<int, int>();
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    {
            //        if (FreqDic.ContainsKey(numbers[i]))
            //            FreqDic[numbers[i]]++;
            //        else
            //            FreqDic[numbers[i]] = 1;

            //    }
            //}

            //    foreach (var item in FreqDic)
            //    {
            //        Console.WriteLine($" {item.Key}  is repeated {item.Value} times");
            //    }


            #endregion

            #region Q5
            //      Write a program in C# Sharp to find maximum and minimum element in an array

            //int[] numbers = { 1,3,5,6};
            //int max = numbers[0];
            //int min = numbers[0];

            //for(int i  = 0; i < numbers.Length; i++) 
            //{
            //    if (numbers[i] > max)
            //        max = numbers[i];
            //    if (numbers[i] < min)
            //        min = numbers[i];
            //}
            //Console.WriteLine($"Max = {max}\n Min = {min}");



            #endregion

            #region Q6

            //      Write a program in C# Sharp to find the second largest element in an array.

            //int[] numbers = { 10, 20, 50, 60 };

            //int max = numbers[0];
            //int secondLargest = numbers[0];
            //foreach (var number in numbers)
            //{
            //    if (number > max)
            //    {
            //        secondLargest = max;
            //        max = number;
            //    }
            //    else if (number > secondLargest && number != max)
            //        secondLargest = number;
            //}
            //Console.WriteLine($"Second Large number is :{secondLargest}");

            #endregion

            #region Q7
            //Consider an Array of Integer values with size N, having values as  in this Example 
            //7 0 0 0 5 6 7 5 0 7 5 3
            //write a program find the longest distance between Two equal cells. In this example.
            //The distance is measured by the number Of cells- for example, the distance between the first and the fourth cell
            //is 2 (cell 2 and cell 3).
            //In the example above, the longest distance is between the first 7 and the
            // 10th 7, with a distance of 8 cells, i.e.the number of cells between the 1st
            // And the 10th 7s.

            //Console.WriteLine("Enter your values in array {n1,n2,n3,...}:");

            //string[] inputarr = Console.ReadLine().Split(',');
            //int[] arr = Array.ConvertAll(inputarr, int.Parse);

            //int maxDist = 0;
            //int dist = 0;

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    for (int j = i + 1; j < arr.Length; j++)
            //    {
            //        if (arr[i] == arr[j])
            //        {
            //            //if (maxDist < j - i - 1)
            //            dist = j - i - 1;
            //            maxDist = Math.Max(maxDist, dist);
            //        }


            //    }
            //}

            //Console.WriteLine($"MAx Distance  ={maxDist}");






            #endregion

            #region Q8
            //  Given a list of space separated words, reverse the order of the words.

            //Console.WriteLine("Enter words separated with space: ");

            //string[] words = Console.ReadLine().Split(' ');

            //for (int i = words.Length - 1; i >= 0; i--)
            //{
            //    Console.Write($"{words[i]} ");
            //}




            #endregion

            #region Q9
            // Write a program to create two multidimensional arrays of same size. Accept value from user
            //  and store them in first array.
            //  Now copy all the elements of first array on second array and print second array.


            // Console.WriteLine("Enter the size of  rows for the array :");

            // int row = int.Parse(Console.ReadLine());

            // Console.WriteLine("Enter the size of  cols for the array :");

            // int col = int.Parse(Console.ReadLine());

            // int[,] arr1 = new int[row,col];
            // int[,] arr2 = new int[row, col];

            //for (int i = 0; i <row; i++)
            // {
            //     for (int j = 0; j <col; j++)
            //     {
            //         Console.WriteLine( $"Enter value for [{i},{j}]: ");
            //         arr1[i,j]=int.Parse(Console.ReadLine());
            //         arr2[i, j] = arr1[i, j];
            //     }
            // }

            // Console.WriteLine("Second Array:");
            // for (int i = 0; i < row; i++)
            // {
            //     for (int j = 0; j < col; j++)
            //     {

            //         Console.Write($"{arr2[i, j]} ");

            //     }
            //     Console.WriteLine();
            // }





            #endregion

            #region Q10
            //Write a Program to Print One Dimensional Array in Reverse Order

            //int[] arr = { 1,4,0,7,6,5,3,9 };

            //for (int i = arr.Length - 1; i >= 0; i--)
            //{
            //    Console.Write($"{arr[i]}, ");

            //}





            #endregion
            //--------------General
            #region Q1
            // Write a program that calculates the simple interest given the  principal amount,
            // rate of interest, and time.
            //The formula for  simple interest is Interest = (principal * rate * time) / 100

            //Console.WriteLine("Enter the Principal: ");
            //double Principal = double.Parse(Console.ReadLine());

            //Console.WriteLine("Enter the Rate: ");
            //double Rate = double.Parse(Console.ReadLine());

            //Console.WriteLine("Enter the Time: ");
            //double Time = double.Parse(Console.ReadLine());

            //double interest = (Principal * Rate * Time) / 100;
            //Console.WriteLine($"Interest = {interest}");

            #endregion

            #region Q2
            // Write a program that calculates the Body Mass Index(BMI) given a person's weight in kilograms and height in meters.
            //The formula for BMI is BMI = (Weight) / (Height * Height)

            //Console.WriteLine("Enter Your Weight in kg : ");
            //double weight = double.Parse(Console.ReadLine());

            //Console.WriteLine("Enter your hight in meter: ");
            //double height = double.Parse(Console.ReadLine());

            //double bmi = weight / Math.Pow(height, 2);

            //Console.WriteLine(bmi);

            #endregion


            #region Q3
            // Write a program that uses the ternary operator to check if the temperature is too hot, too cold, or just good.
            // Assign the result in a variable then display the result.
            // Assume that below 10 degrees is "Just Cold", above 30 degrees is "Just Hot", and anything else is "Just Good"

            //Console.WriteLine("Enter Temprature : ");
            //double Temprature = double.Parse(Console.ReadLine());

            //string result = Temprature < 10 ? "Just Cold" : (Temprature > 30 ? "Just Hot" : "Just Good");
            //Console.WriteLine(result);

            #endregion

            #region Q4
            //Write a program that takes the date from the user and displays it in various formats using string interpolation.


            //Console.WriteLine("Enter Day:");
            //int day = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter Month:");
            //int month = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter year:");
            //int year = int.Parse(Console.ReadLine());

            //DateTime date = new DateTime(year, month, day);

            //Console.WriteLine($"Today’s date : {date.Day} , {date.Month} , {date.Year}");
            //Console.WriteLine($"Today’s date : {date.Day} / {date.Month} / {date.Year}");
            //Console.WriteLine($"Today’s date : {date.Day} - {date.Month} - {date.Year}");



            #endregion

            #region Q5
            //What is the output of the following C# code?
            //DateTime date = new DateTime(2024, 6, 14);
            //Console.WriteLine($"The event is on {date:MM/dd/yyyy}");

            // the output is  c)	 The event is on 06/14/2024



            #endregion

        }
    }
}
