using Expanse.Web.Clients.GraphQL;
using Expanse.Web.Models;

namespace Expanse.Web.Extensions.Models;

public static class ShipExtensions
{
    public static Ship ToShip(this IGetHomePageOverview_Ships entity)
    {
        return new Ship
        {
            Image = entity.Image!,
            Name = entity.Name!,
            HomePort = entity.Home_port!,
        };
    }
}