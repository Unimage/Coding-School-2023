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
        
        //6
        ExerciseSix exerSix = new ExerciseSix();
        exerSix.CaclulateSecondsUsingLibraries();

        //7
        ExerciseSeven exerSeven = new ExerciseSeven();
        exerSeven.ConvertTemp();
        Console.ReadLine();
    }
}