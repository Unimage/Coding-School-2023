using Session_05;
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        //--------------- 1---------------- 
        Console.WriteLine("Please enter a string to be reversed: ");
        string input = Console.ReadLine();

        ExerciseOne reverser = new ExerciseOne();
        ;
        Console.WriteLine("Reversed String : {0} ", reverser.ReverseString(input));

        //---------------2------------------
        Console.WriteLine("Enter a posivite integer:");
        input = Console.ReadLine();
        int inputInt;

        try
        {
            inputInt = Convert.ToInt32(input);     
        }
        catch (System.FormatException)
        {
            inputInt = 0;
            Console.WriteLine("Definitelly not an integer please try again.");
        }
        ExerciseTwo calculator = new ExerciseTwo();
        Console.WriteLine("Please enter an function : \n1.Summary \n2.Product ");
        string inputFunction = Console.ReadLine();
        int function = Convert.ToInt32(inputFunction);
        if(function == 1)
        {
            Console.WriteLine("The Sum of numbers from 1 to {0} is {1}\n", inputInt, calculator.Calculate(inputInt, function));
        }
        else if (function ==2)
        {
            Console.WriteLine("The Product of numbers from 1 to {0} is {1}\n", inputInt, calculator.Calculate(inputInt, function));
        }
        else
        {
            Console.WriteLine("Error at choosing function. either press 1 or 2.");
        }

        //--------------3--------------------
        ExerciseThree findPrimes = new ExerciseThree();
        Console.WriteLine("\nEnter an integer: ");
        input = Console.ReadLine();
        int number = Convert.ToInt32(input);

        int[] primes = findPrimes.FindAllPrimes(number);
        foreach(var value in primes)
        {
            Console.Write(value + " ");
        }
        Console.WriteLine();
        


        //----------------4---------------------- 
        ExerciseFour multiplication = new ExerciseFour();
        int[] arrayOne = new int[] { 2, 4, 9, 12 };
        int[] arrayTwo = new int[] { 1, 3, 7, 10 };
        int[] result = multiplication.MultiplyArray(arrayOne, arrayTwo);
        Console.WriteLine("\nArray1: ");
        foreach (var value in arrayOne)
        {
            Console.Write(value + " ");
        }

        Console.WriteLine("\nArray2: ");
        foreach (var value in arrayTwo)
        {
            Console.Write(value + " ");
        }
        
        Console.WriteLine("\n\nProduct of two arrays is: ");
        foreach (var value in result)
        {
            Console.Write(value + " ");
        }


        //-----------------5-----------------------------
        ExerciseFive arraySort = new ExerciseFive();
        int[] unsortedArray = { 0, -2, 1, 20, -31, 50, -4, 17, 89, 100 };
        Console.WriteLine("\n\nInitial Array:");
        foreach (var value in unsortedArray)
        {
            Console.Write(value + " ");
        }
        int[] sortedArray = arraySort.SortArray(unsortedArray);
        Console.WriteLine("\nPrinting sorted array using bubble sort");
        foreach (var value in sortedArray)
        {
            Console.Write(value + " ");
        }
        Console.ReadLine();
        

    }
}