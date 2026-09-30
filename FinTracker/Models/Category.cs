namespace FinTracker.Models;

public enum CategoryType {Income , Expense}

public class Category
{
    public int Id { get; set; }
    public string? UserId { get; set; } //null = system category, accesable 
}