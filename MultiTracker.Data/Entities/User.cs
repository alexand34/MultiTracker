using System;
using MongoDB.Extensions.Repository.Models;

namespace MultiTracker.Data.Entities
{
    public class User : MongoEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}