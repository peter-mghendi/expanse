using Expanse.Web.Clients.GraphQL;
using Expanse.Web.Models;

namespace Expanse.Web.Extensions.Models;

public static class MissionExtensions
{
    public static Mission? ToMission(this IGetHomePageOverview_Missions entity)
    {
        return new Mission
        {
            Description = entity.Description!,
            Name = entity.Name!,
            Twitter = entity.Twitter!,
            Wikipedia = entity.Wikipedia!
        };
    }
}