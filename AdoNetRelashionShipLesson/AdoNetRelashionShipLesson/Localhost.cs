namespace AdoNetRelashionShipLesson
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class Localhost : DbContext
    {

        public Localhost()
            : base("name=Localhost")
        {

        }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Player> Players { get; set; }
    }


}