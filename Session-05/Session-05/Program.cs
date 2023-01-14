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
        Console.ReadLine();


        
    }
}