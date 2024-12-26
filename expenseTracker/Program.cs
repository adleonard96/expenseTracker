using System.Diagnostics;

class Driver
{
    static void Main(string[] args)
    {
        if (args.Length == 0)
        {
            Console.WriteLine("Please enter one of the following commands:\n-add\n-list\n-summary\n-delete\n-budget\n-export\n");
            return;
        }
        
        ExpenseHandler expenses = new();
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

                var maxId = expenses.Expenses.Max(w => w.Id);
                expense.Id = ++maxId;
                expense.Date = DateTime.Now;
                expenses.Add(expense);
                break;
            case "list":
                
                Console.WriteLine("-----------------------------------------------------");
                Console.WriteLine("| Description | Price |      Date Added      |  Id  |");
                Console.WriteLine("-----------------------------------------------------");
                foreach(Expense e in expenses.Expenses)
                {
                    Console.WriteLine(string.Format("| {0, 8} | {1, 5} | {2, 5} | {3, 4} |", e.Description.PadRight(11, ' '), e.Price, e.Date.ToString(), e.Id));
                };
                Console.WriteLine("-----------------------------------------------------");
                break;
            case "summary":
                var total = expenses.Expenses.Sum(expense => expense.Price);
                Console.WriteLine("Expenses Summary");
                Console.WriteLine("----------------");
                Console.WriteLine(string.Format("Total: {0}", total));
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