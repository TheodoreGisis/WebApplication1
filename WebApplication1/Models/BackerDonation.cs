namespace WebApplication1.Models
{
    public class BackerDonation
    {
        public int BackerId { get; set; }
        public Backer? Backer;
        public int DonationProjectId { get; set; }
        public DonationProject? DonationProject { get; set; }

        public BackerDonation(int id, int did)
        {

            BackerId = id;
            DonationProjectId = did;

        }
        public BackerDonation() { }



    }
}
