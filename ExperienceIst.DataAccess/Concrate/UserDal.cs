using ExperienceIst.DataAccess.Abstract;
using ExperienceIst.Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ExperienceIst.DataAccess.Concrate
{
    public class UserDal : IUserDal
    {
        public User Get(Expression<Func<User, bool>> filter)
        {
            using (ExperienceIstContext context = new ExperienceIstContext())
            {
                return context.Set<User>().SingleOrDefault(filter);
            }
        }
    }
}
