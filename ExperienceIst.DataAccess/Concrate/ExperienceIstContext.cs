using ExperienceIst.Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace ExperienceIst.DataAccess.Concrate
{
    public class ExperienceIstContext:DbContext
    {
        public ExperienceIstContext() //: base("Name=AsascContext")
        {
            Database.SetInitializer<ExperienceIstContext>(null);
        }
        public DbSet<Request> Requests { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
