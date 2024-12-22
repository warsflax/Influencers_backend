using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace husshussAPIBack.Models
{
public class Influencer
{
     [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ID { get; set; } // Foreign Key
    public string description { get; set; }
    public string categorie { get; set; }
    public string location { get; set; }
    public string type_de_contenu { get; set; }
    public string langue { get; set; }
    public int FollowerCount { get; set; }
    public string category { get; set; }
    public string compensation { get; set; }
    public string types_de_partenariats { get; set; }
    
    public int UserID { get; set; } // Navigation property
    public User User{ get; set; } // Navigation property

    public ICollection<Socialmedia>? SocialMedias { get; set; }

}

}