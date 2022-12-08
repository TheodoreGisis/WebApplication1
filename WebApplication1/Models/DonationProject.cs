namespace WebApplication1.Models
{
    public class DonationProject
    {

        public int DonationProjectId { get; set; }
        public string ProjectName { get; set; } = "";
        public int DonationPrice { get; set; } = 0;
        public List<BackerDonation>? DonationProjects = new List<BackerDonation> { };


        public DonationProject(string projectname, int donationprice)
        {

            this.ProjectName = projectname;
            this.DonationPrice = donationprice;
        }
        public DonationProject() { }


    }
}
