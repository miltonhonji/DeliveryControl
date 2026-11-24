using System;
using DeliveryControl.Entities.Entities;

namespace DeliveryControl.Domain.Interfaces
{
    public interface IRouteRepository : IBaseRepository<Route>
    {
        Task<Route> GetByInitialDateAndFinalDateAsync(DateTime initialDate, DateTime finalDate);
    }
}