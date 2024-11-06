namespace husshussAPIBack.Models
{
public class Application
{
    public int ApplicationID { get; set; }
    public int RelatedID { get; set; } // References CampaignID or OfferID
    public string Type { get; set; } // ENUM('Campaign', 'Offer')
    public int ApplicantID { get; set; } // Foreign Key

    public DateTime SubmissionDate { get; set; }
    public string Proposal { get; set; }
    public string Status { get; set; } // ENUM('Pending', 'Accepted', 'Rejected')

    public User Applicant { get; set; } // Navigation property
}

}