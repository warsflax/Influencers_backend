namespace husshussAPIBack.Models
{
public class Offer
{
    public int OfferID { get; set; }
    public int InfluencerID { get; set; } // Foreign Key
    public string Title { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public string Status { get; set; } // ENUM('Open', 'Closed', 'In Progress')
    public string Category { get; set; }

    public Influencer Influencer { get; set; } // Navigation property
}


}