using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MongoDB.Extensions.Repository.Interfaces;
using MultiTracker.Data.Entities;

namespace MultiTracker.Data.DataInterfaces
{
    public interface ICalendarRepository : IMongoRepository<CalendarItem>
    {
        Task<IEnumerable<CalendarItem>> GetAllItems();
        Task AddItem(CalendarItem item, CancellationToken cancellationToken = default);
        Task<CalendarItem> GetById(string id, CancellationToken cancellationToken = default);
        Task<ICollection<CalendarItem>> GetByNameAsync(string name, CancellationToken cancellationToken  = default);
    }
}