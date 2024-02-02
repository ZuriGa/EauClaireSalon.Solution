using System.Collections.Generic;

namespace HairSalon.Models
{
  public class Stylist
  {
    public int StylistId { get; set; }

    public string Name { get; set; }

    public DateTime HireDate { get; set; }

    public List<Client> Clients { get; set; }

    public int ClientId { get; set; }

    public Client Client { get; set; }
  }
}