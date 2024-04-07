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
        private readonly ExperienceIstContext _context;

        public UserDal(ExperienceIstContext context)
        {
            _context = context;
        }
        public User Get(Expression<Func<User, bool>> filter)
        {

                return _context.Set<User>().SingleOrDefault(filter);
            
        }
    }
}
