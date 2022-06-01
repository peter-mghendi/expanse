using Expanse.Web.Clients.GraphQL;

namespace Expanse.Web.Models;

public class Mission : IGetHomePageOverview_Missions
{
    public string Name { get; set; } = null!;
    public string Description { get; set; } = null!;
    public string? Twitter { get; set; }
    public string? Wikipedia { get; set; }
}