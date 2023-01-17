using Session_07;

internal class Program {
    private static void Main(string[] args) {
        ActionResolver resolver= new ActionResolver();
        ActionResponse response= new ActionResponse();
        ActionRequest request1= new ActionRequest() { Input="By fire be Purged",Action=ActionEnum.Uppercase};

        ActionRequest request2 = new ActionRequest() { Input = "Illidan", Action = ActionEnum.Reverse };

        ActionRequest request3 = new ActionRequest() { Input = "43", Action = ActionEnum.Convert };

        //ActionRequest requestNull = new ActionRequest() { Input = null, Action = ActionEnum.Uppercase };

        response = resolver.Excecute(request1); 
        response = resolver.Excecute(request2); 
        response = resolver.Excecute(request3);
        // response = resolver.Excecute(requestNull);

        Console.Write(resolver.Logger.ReadAll());




    }
}