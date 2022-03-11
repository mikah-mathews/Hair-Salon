using System.Collections.Generic;
namespace HairSalon.Models
{
  public class Client
  {
    public Client()
    {
      this.Stylists = new HashSet<Stylist>();
    }

    public int ClientId { get; set; }
    public string ClientName { get; set; }
    public int PhoneNumber { get; set; }
    public string AppointmentDate { get; set; }
    public string Service { get; set; }
    public virtual ICollection<Stylist> Stylists { get; set; }
  }
}