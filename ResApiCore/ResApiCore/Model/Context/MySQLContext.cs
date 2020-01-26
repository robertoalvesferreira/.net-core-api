using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResApiCore.Model.Context
{
    public class MySQLContext : DbContext
    {
        public MySQLContext()
        {

        }
        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options) { }

        public DbSet<Person> Persons {get; set;}

        public DbSet<Profile> Profile { get; set; }

        public DbSet<User> Users { get; set; }
    }
}
