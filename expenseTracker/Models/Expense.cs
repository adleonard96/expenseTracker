class Expense {
    public int? Id { get; set; }
    public double? Price { get; set; }
    public DateTime? Date{ get; set; }
    public string? Description { get; set; }

    public Expense(int id, double price, string description) { 
        Id = id;
        Price = price;
        Description = description;
        Date = DateTime.Now;
        Description = description;
    }
    public Expense(int id, double price, string description, DateTime date) {
        Id = id;
        Price = price;
        Description = description;
        Date = date;
    }

    public Expense(){}
}