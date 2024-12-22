
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace husshussAPIBack.Models

{
public class Socialmedia
{
  [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]   
    public int ID { get; set; } // Foreign Key
    public string social_media_name { get; set; }
    public string nb_followers { get; set; }
    public string description { get; set; }
     // Clé étrangère vers Influencer
    public int InfluencerID { get; set; } // Foreign Key

    // Propriété de navigation vers Influencer
    public Influencer Influencer { get; set; }
}

}