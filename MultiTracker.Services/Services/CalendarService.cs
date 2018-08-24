using System.Collections.Generic;
using System.Globalization;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using MultiTracker.Data.DataInterfaces;
using MultiTracker.Data.Entities;
using MultiTracker.Services.Crud;
using MultiTracker.Services.Interfaces;

namespace MultiTracker.Services.Services
{
    public class  CalendarService : MongoCrudService<ICalendarRepository, CalendarItem, CalendarItem, CalendarItem>,
        ICalendarService
    {
        public CalendarService(ICalendarRepository repository, IMapper mapper, IHttpContextAccessor httpContextAccessor)
            : base(repository, mapper, httpContextAccessor)
        {
        }

        public List<Calendar> GetTodayEvents()
        {
            throw new System.NotImplementedException();
        }

        public Task AddEvent(CalendarItem calendarEvent)
        {
            return this.Repository.AddItem(calendarEvent, RequestAborted);
        }

        public Task DeleteEvent(string id)
        {
            throw new System.NotImplementedException();
        }
    }
}