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
                const int NUMBER_OF_ARGS = 5;
                if (args.Length < NUMBER_OF_ARGS)
                {
                    Console.WriteLine("Not enough arguments where passed");
                    throw new Exception();
                }
                if (args.Length > NUMBER_OF_ARGS)
                {
                    Console.WriteLine("To many arguments passed for adding an expense");
                    throw new Exception();
                }
                var expense = new Expense();
                for(int i = 1; i < args.Length; i += 2)
                {
                    switch(args[i].ToLower())
                    {
                        case "--description":
                            expense.Description = args[i+1];
                            break;
                        case "--amount":
                            expense.Price = Convert.ToDouble(args[i+1].Replace(",", ""));
                            break;
                    }
                }

                ExpenseHandler expenses = new();
                var numberOfElements = expenses.Expenses.Count;
                expense.Id = numberOfElements;
                expense.Date = new DateTime();
                expenses.Add(expense);
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