using AutoMapper;
using MultiTracker.Data.Entities;

namespace MultiTracker.Data.Mapping
{
    public class CalendarMappingProfile : Profile
    {
        public CalendarMappingProfile()
        {
            CreateMap<CalendarItem, CalendarItem>();
        }
    }
}