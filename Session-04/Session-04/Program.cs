using Session_04;
internal class Program
{
    private static void Main(string[] args)
    {
        //1
        ExerciseOne exerOne = new ExerciseOne();
        Console.WriteLine(exerOne.HelloMessage());
        

        //2
        ExerciseTwo exerTwo = new ExerciseTwo();
        exerTwo.SumAndDivition();
        Console.ReadLine();
    }
}