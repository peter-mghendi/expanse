using Expanse.Web.Clients.GraphQL;
using Expanse.Web.Clients.GraphQL.State;
using Expanse.Web.Models;

namespace Expanse.Web.Extensions.Models;

public static class LaunchExtensions
{
    public static Launch? ToLaunch(this IGetHomePageOverview_LaunchesPast? entity)
    {
        return entity switch
        {
            null => null,
            _ => new Launch
            {
                Images = entity.Links!.Flickr_images!.ToList()!,
                Date = (DateTime) entity.Launch_date_local!,
                Site = entity.Launch_site!.Site_name_long!,
                Success = (bool) entity.Launch_success!,
                MissionName = entity.Mission_name!
            }
        };
    }
}