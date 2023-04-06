using System.Collections.Generic;

namespace PierresTreats.Models
{
  public class Flavor
  {
    public int FlavorId { get; set; }
    public string Name { get; set; }
    public List<TreatFlavor> JoinEntities { get; set; }
  }
}