class Driver
{
    static void Main(string[] args)
    {
        if (args.Length == 0)
        {
            Console.WriteLine("Please enter one of the following commands:\n-add\n-list\n-summary\n-delete\n-budget\n-export\n");
            return;
        }
        
        switch(args[0].ToLower()) 
        {
            case "add":
                Console.WriteLine("Unimplimented");
                break;
            case "list":
                Console.WriteLine("Unimplimented");
                break;
            case "summary":
                Console.WriteLine("Unimplimented");
                break;
            case "delete":
                Console.WriteLine("Unimplimented");
                break;
            case "budget":
                Console.WriteLine("Unimplimented");
                break;
            case "export":
                Console.WriteLine("Unimplimented");
                break; 
            default: 
                Console.WriteLine(string.Format("Invalid argument of {0}", args[0]));
                break;
        }
    }
}