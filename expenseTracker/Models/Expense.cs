class Expense {
    private int Id { get; set; }
    private double Price { get; set; }
    private DateTime Date{ get; set; }
    private string Description { get; set; }

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

}