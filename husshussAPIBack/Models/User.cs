using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace husshussAPIBack.Models
{
   public class User
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int UserID { get; set; }
    public string UserType { get; set; } // ENUM ('Influencer', 'Sponsor', 'Agency')
    public string FullName { get; set; }
        public string ProfilePicture { get; set; }
        public DateTime DateJoined { get; set; }
        public string Email { get; set; }
    public string Password { get; set; }
  

    //public ICollection<Message> SentMessages { get; set; }
    //public ICollection<Message> ReceivedMessages { get; set; }
    //public ICollection<Review> ReviewsGiven { get; set; }
    //public ICollection<Review> ReviewsReceived { get; set; }
}

}
