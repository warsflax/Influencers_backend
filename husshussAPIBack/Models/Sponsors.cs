namespace husshussAPIBack.Models
{
public class Sponsor
{
    public int SponsorID { get; set; } // Foreign Key
    public string CompanyName { get; set; }
    public string CompanyWebsite { get; set; }
    public string Industry { get; set; }
    public decimal Budget { get; set; }

    public User User { get; set; } // Navigation property
}
}