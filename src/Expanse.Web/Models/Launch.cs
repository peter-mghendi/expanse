using Expanse.Web.Clients.GraphQL;

namespace Expanse.Web.Models;

public class Launch
{
    public string MissionName { get; set; } = null!;
    public DateTime Date { get; set; }
    public string Site { get; set; } = null!;
    public bool Success { get; set; }
    public List<string> Images { get; set; } = null!;
}