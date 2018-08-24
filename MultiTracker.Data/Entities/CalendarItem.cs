using System;
using MongoDB.Extensions.Repository.Models;
using MultiTracker.Data.CommonTypes;

namespace MultiTracker.Data.Entities
{
    public class CalendarItem : MongoEntity
    {
        public string Name { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime? EndingTime { get; set; }
        public CalendarEventType EventType { get; set; }
        public User User { get; set; }
    }
}