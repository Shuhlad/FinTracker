namespace FinTracker.Models;


    public enum BudgetPeriod { Weekly, Monthly }

    public class Budget
    {
        public int Id { get; set; }

        public string UserId { get; set; } = string.Empty;
        public User User { get; set; } = null!;

        public int CategoryId { get; set; }
        public Category Category { get; set; } = null!;

        public decimal Limit { get; set; }
        public BudgetPeriod Period { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
    
