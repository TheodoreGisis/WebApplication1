namespace WebApplication1.Models
{
    public class Project
    {
        public int projectId { get; set; }
        public string title { get; set; } = "";
        public string description { get; set; } = "";
        public int CreatorId { get; set; }
        public int moneyCollected { get; set; } = 1;
        public int price { get; set; } = 0;
        public int CategoryId { get; set; }
        public Category category { get; set; } = null!;


        public Project() { }

        public Project(string title, string description, int creatorId, int moneyCollected, int price, Category category)
        {
            this.title = title;
            this.description = description;
            this.CreatorId = creatorId;
            this.moneyCollected = moneyCollected;
            this.price = price;

        }

        public Project(string title, string description, int moneyCollected, int price)
        {
            this.title = title;
            this.description = description;
            this.moneyCollected = moneyCollected;
            this.price = price;
        }

        public int Find_precent()
        {
            return moneyCollected - price;
        }
    }
}
