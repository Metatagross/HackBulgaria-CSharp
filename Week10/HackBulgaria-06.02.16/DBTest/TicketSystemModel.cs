namespace DBTest
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using TicketSystem;
    public class TicketSystemModel : DbContext
    {
        // Your context has been configured to use a 'TicketSystemModel' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'DBTest.TicketSystemModel' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'TicketSystemModel' 
        // connection string in the application configuration file.
        public TicketSystemModel ( )
            : base("name=TicketSystemModel")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Train> Trains { get; set; }
        public virtual DbSet<Schedule> Shedules { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Seat> Seats { get; set; }
        public virtual DbSet<Ticket> Tickets { get; set; }
        public virtual DbSet<DiscountCard> DiscountCards { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}