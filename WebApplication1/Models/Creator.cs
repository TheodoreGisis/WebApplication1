namespace WebApplication1.Models
{
    public class Creator
    {

        public int Id { get; set; }
        public string firstName { get; set; } = "";
        public string lastName { get; set; } = "";
        public string email { get; set; } = "";
        public int password { get; set; }
        public List<Project>? projectList { get; set; } = new List<Project>();

        public Creator(string firstName, string lastName, string email, int password, Project project)
        {

            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.password = password;
        }
        public Creator(string firstName, string lastName, string email, int password) {

            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.password = password;
        }
        public Creator() { }




    }
}
