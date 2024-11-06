namespace husshussAPIBack.Models
{
   public class Campaign
{
    public int CampaignID { get; set; }
    public int SponsorID { get; set; } // Foreign Key
    public string Title { get; set; }
    public string Description { get; set; }
    public decimal Budget { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public string Status { get; set; } // ENUM('Open', 'Closed', 'In Progress')

    public Sponsor Sponsor { get; set; } // Navigation property
}
 
}