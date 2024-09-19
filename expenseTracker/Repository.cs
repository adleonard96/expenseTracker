using System.Text.Json;

class Repository {
    public static List<Expense> GetHistory(){
        using StreamReader reader = new("history.json");
        string json = reader.ReadToEnd();
        if(json.Contains("")){
            return [];
        }
        var expenses = JsonSerializer.Deserialize<List<Expense>>(json);
        if(expenses is null){
            return [];
        }

        return expenses;
    }

    public static bool CheckForHistoryFile() {
        return File.Exists("history.json");
    }

    public static void CreateHistoryFile(){
        var json = JsonSerializer.Serialize("[]");
    }
}