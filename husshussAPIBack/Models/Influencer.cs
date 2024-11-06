namespace husshussAPIBack.Models
{
public class Influencer
{
   
    public int InfluencerID { get; set; } // Foreign Key
    public string SocialMediaHandles { get; set; }
    public int FollowerCount { get; set; }
    public string Category { get; set; }
    public float EngagementRate { get; set; }
    
    public User User { get; set; } // Navigation property
}

}