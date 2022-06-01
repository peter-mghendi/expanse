using Expanse.Web.Clients.GraphQL;
using Expanse.Web.Clients.GraphQL.State;
using Expanse.Web.Models;

namespace Expanse.Web.Extensions.Models;

public static class RocketExtensions
{
    public static Rocket? ToRocket(this IGetHomePageOverview_Rockets? entity)
    {
        return entity switch
        {
            null => null,
            _ => new Rocket
            {
                Active = entity.Active ?? false,
                FirstFlight = (DateTime) entity.First_flight!,
                Mass = entity.Mass?.Kg ?? 0,
                Name = entity.Name ?? string.Empty
            }
        };
    }
}