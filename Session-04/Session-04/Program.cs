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

        //3

        ExerciseThree exerThree = new ExerciseThree();
        exerThree.MathOperations();

        //4
        ExerciseFour exerFour = new ExerciseFour();
        exerFour.DisplayMessage();
        

        //5
        ExerciseFive exerFive = new ExerciseFive();
        exerFive.CaclulateSeconds();
        Console.ReadLine();
    }
}