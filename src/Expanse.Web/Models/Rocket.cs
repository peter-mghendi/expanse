namespace Expanse.Web.Models;

public class Rocket
{
    public string Name { get; set; } = null!;
    public bool Active { get; set; }
    public int Mass { get; set; }
    public DateTime? FirstFlight { get; set; }
}