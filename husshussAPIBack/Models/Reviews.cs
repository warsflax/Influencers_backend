namespace husshussAPIBack.Models
{
    public class Review
{
    public int ReviewID { get; set; }
    public int ReviewerID { get; set; } // Foreign Key
    public int RevieweeID { get; set; } // Foreign Key
    public int CampaignID { get; set; } // Foreign Key
    public int Rating { get; set; } // Out of 5
    public string Feedback { get; set; }
    public DateTime ReviewDate { get; set; }

    public User Reviewer { get; set; } // Navigation property
    public User Reviewee { get; set; } // Navigation property
    public Campaign Campaign { get; set; } // Navigation property
}

}