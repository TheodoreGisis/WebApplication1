namespace WebApplication1.Models
{
    public class Backer
    {

        public int Id { get; set; }
        public string firstName { get; set; } = "";
        public string lastName { get; set; } = "";
        public string email { get; set; } = "";
        public int password { get; set; }

        public List<BackerDonation>? DonationProjects { get; set; } = new List<BackerDonation> { };


        public Backer(string firstName, string lastName, string email, int password)
        {

            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.password = password;

        }

    }
}
