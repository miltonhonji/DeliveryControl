using System;
using DeliveryControl.Entities.Entities;

namespace DeliveryControl.Domain.Interfaces
{
    public interface IWorkDayRepository : IBaseRepository<WorkDay>
    {
        Task<IEnumerable<WorkDay>> GetByInitialDateAndFinalDateAsync(DateTime startDate, DateTime endDate);
    }
}