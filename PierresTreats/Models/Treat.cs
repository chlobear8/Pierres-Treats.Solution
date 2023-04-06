using System.Collections.Generic;

namespace PierresTreats.Models
{
  public class Treat
  {
    public int TreatId { get; set; }
    public string Name { get; set; }
    public List<TreatFlavor> JoinEntities { get; set; }
  }
}