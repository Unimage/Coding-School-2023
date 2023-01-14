using Session_05;

internal class Program
{
    private static void Main(string[] args)
    {
        // 1 
        Console.WriteLine("Please enter a string to be reversed: ");
        string input = Console.ReadLine();

        ExerciseOne reverser = new ExerciseOne();
        ;
        Console.WriteLine("Reversed String : {0} ", reverser.ReverseString(input));

        //2
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
            Console.WriteLine("The Sum of numbers from 1 to {0} is {1}", inputInt, calculator.Calculate(inputInt, function));
        }
        else if (function ==2)
        {
            Console.WriteLine("The Product of numbers from 1 to {0} is {1}", inputInt, calculator.Calculate(inputInt, function));
        }
        else
        {
            Console.WriteLine("Error at choosing function. either press 1 or 2.");
        }
        Console.ReadLine();
    }
}