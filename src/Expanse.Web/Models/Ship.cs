using Expanse.Web.Clients.GraphQL;

namespace Expanse.Web.Models;

public class Ship
{
    public string Name { get; set; } = null!;
    public string HomePort { get; set; } = null!;
    public string Image { get; set; } = null!;
}