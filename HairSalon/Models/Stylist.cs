namespace HairSalon.Models
{
  public class Stylist
  {
    public int StylistId { get; set; }
    public string StylistName { get; set; }
    public virtual Client Client { get; set; }
  }
}