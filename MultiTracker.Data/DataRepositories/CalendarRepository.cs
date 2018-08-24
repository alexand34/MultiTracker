using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Extensions.Repository;
using MongoDB.Extensions.Repository.Extensions;
using MongoDB.Extensions.Repository.Interfaces;
using MultiTracker.Data.DataInterfaces;
using MultiTracker.Data.Entities;

namespace MultiTracker.Data.DataRepositories
{
    public class CalendarRepository : MongoRepository<CalendarItem>, ICalendarRepository
    {
        public CalendarRepository(IMongoContext context) : base(context) { } 

        public async Task<ICollection<CalendarItem>> GetByNameAsync(string name, CancellationToken cancellationToken = default)
        { 
            return await FindAsync(Filter.Eq(x => x.Name, name), cancellationToken,
                new FindOptions<CalendarItem>().WithCaseInsensitiveCollation());
        }

        public async Task AddItem(CalendarItem item, CancellationToken cancellationToken = default)
        {
            await AddAsync(item, cancellationToken);
        }

        public async Task<CalendarItem> GetById(string id, CancellationToken cancellationToken = default)
        {
            return await FindOneAsync(Filter.Eq(x => x.Id, id), cancellationToken,
                new FindOptions<CalendarItem>().WithCaseInsensitiveCollation());
        }

        public Task<IEnumerable<CalendarItem>> GetAllItems()
        {
            throw new System.NotImplementedException();
        } 
    }
}