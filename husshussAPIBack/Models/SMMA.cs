namespace husshussAPIBack.Models
{
    public class SMMA
{
    public int SMMA_ID { get; set; } // Foreign Key
    public string CompanyName { get; set; }
    public string Expertise { get; set; }
    public int ClientBase { get; set; }

    public User User { get; set; } // Navigation property
}

}