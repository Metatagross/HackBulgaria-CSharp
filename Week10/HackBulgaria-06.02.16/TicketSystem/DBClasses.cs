using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace TicketSystem
{
    public class City
    {
        public int CityID { get; set; }
        public string Name { get; set; }
    }
    public class Train
    {
        public int TrainID { get; set; }
        public List<Seat> Seats { get; set; }
        public string Description { get; set; }
    }
    public class Schedule
    {
        public int ScheduleID { get; set; }
        public string StartCity { get; set; }
        public string EndCity { get; set; }
        public TimeSpan TravelTime { get; set; }
        public Train TrainID { get; set; }
        public decimal TicketPrice { get; set; }
    }
    public class User
    {
        public int UserID { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string DiscountCardNumber { get; set; }
        public string MyPCreditCardNumber { get; set; }
        public string Address { get; set; }
        public string ZipCode { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    public class Seat
    {
        public enum Classes { First, Second, Sleep };
        public int SeatID { get; set; }
        public bool IsTaken { get; set; }
        public Classes SeatClass { get; set; }
        public int Wagon { get; set; }
        public int Compartment { get; set; }
        public int SeatNumber { get; set; }
        public override string ToString ( )
        {
            return string.Format($"{SeatID} - {IsTaken} - {SeatClass}");
        }
    }
    public class Ticket
    {
        public int TicketID { get; set; }
        public DateTime TripDateAndTime { get; set; }
        public decimal OriginalPrice { get; set; }
        public decimal PriceSold { get; set; }
        public int UserSoldTo { get; set; }
        public int SeatNumber { get; set; }

    }
    public class DiscountCard
    {
        public enum Type { pensioner, isic, children }
        public int DiscountCardID { get; set; }
        public Type CardType { get; set; }
        public bool ApplyForFirstClass { get; set; }
    }
    public class BlogContext : DbContext
    {
        public DbSet<City> Cities { get; set; }
        public DbSet<Train> Trains { get; set; }
        public DbSet<Schedule> Shedules { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Seat> Seats { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<DiscountCard> DiscountCards { get; set; }
    }
}
