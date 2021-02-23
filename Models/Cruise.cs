using System.Collections.Generic;

namespace csharp_vacation.Models
{
  class Cruise : Vacation
  {
    public List<string> Ports { get; set; }
  }
}