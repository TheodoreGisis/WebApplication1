namespace WebApplication1.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string CategoryName { get; set; } = "";


        public Category(string name)
        {
            this.CategoryName = name;
        }

        public Category() { }




    }
}
