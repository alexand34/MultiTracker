using System.Collections.Generic;
using System.Globalization;
using System.Threading.Tasks;
using MultiTracker.Data.Entities;

namespace MultiTracker.Services.Interfaces
{
    public interface ICalendarService
    {
        List<Calendar> GetTodayEvents();
        Task AddEvent(CalendarItem calendarEvent);
        Task DeleteEvent(string id);
    }
}