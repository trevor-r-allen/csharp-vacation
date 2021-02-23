namespace csharp_vacation.Models
{
  abstract class Vacation
  {
    public int Id { get; set; }
    public float Price { get; set; }
    public int Passengers { get; set; }
    public string DepartureDate { get; set; }
    public string ReturnDate { get; set; }


  }
}