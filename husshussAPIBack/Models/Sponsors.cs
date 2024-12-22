using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace husshussAPIBack.Models
{
public class Sponsor
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int SponsorID { get; set; } // Foreign Key
    public string CompanyName { get; set; }
    public string CompanyWebsite { get; set; }
    public string Industry { get; set; }
    public decimal Budget { get; set; }

    public User User { get; set; } // Navigation property
}
}