class ExpenseHandler {
    public List<Expense> Expenses { get; set; }

    public ExpenseHandler() {
        Expenses = Repository.GetExpenseHistory();
    }

    public void Add(Expense expense) {
        Expenses.Add(expense);
        Repository.SaveExpenseHistory(Expenses);
    }
}