namespace husshussAPIBack.Models
{
public class Message
{
    public int MessageID { get; set; }
    public int SenderID { get; set; } // Foreign Key
    public int ReceiverID { get; set; } // Foreign Key
    public string Content { get; set; }
    public DateTime Timestamp { get; set; }
    public bool IsRead { get; set; }

    public User Sender { get; set; } // Navigation property
    public User Receiver { get; set; } // Navigation property
}


}