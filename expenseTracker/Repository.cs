using System.Text.Json;

class Repository
{
    public static List<Expense> GetExpenseHistory()
    {
        if (!CheckForHistoryFile())
        {
            return [];
        }
        using StreamReader reader = new("history.json");
        string json = reader.ReadToEnd();
        if (json.Equals(""))
        {
            return [];
        }
        var expenses = JsonSerializer.Deserialize<List<Expense>>(json);
        if (expenses is null)
        {
            return [];
        }

        return expenses;
    }

    private static bool CheckForHistoryFile()
    {
        return File.Exists("history.json");
    }

    public static void SaveExpenseHistory(List<Expense> expenses)
    {
        var json = JsonSerializer.Serialize(expenses);
        Console.WriteLine(json);
        const string FILE_NAME = "history.json";
        using StreamWriter sw = File.CreateText(FILE_NAME);
        sw.Write(json);

    }
}