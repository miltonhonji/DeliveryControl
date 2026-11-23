using System;
using DeliveryControl.Entities.Entities;;

namespace DeliveryControl.Domain.Interfaces
{
    public interface IRouteRepository : IBaseRepository<Route>
    {
        //Task<IEnumerable<Entities.Entities.Route>> GetByWorkDayIdAsync(int workDayId);
        //Task<IEnumerable<Entities.Entities.Route>> GetByDeparturePointIdAsync(int departurePointId);
    }
}