using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExperienceIst.DataAccess.Concrate
{
    public class ExperienceIstContext:DbContext
    {
        public ExperienceIstContext() //: base("Name=AsascContext")
        {
            Database.SetInitializer<ExperienceIstContext>(null);
        }
    }
}
