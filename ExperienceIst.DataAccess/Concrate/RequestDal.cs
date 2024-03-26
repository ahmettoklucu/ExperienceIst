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
    public class RequestDal : IRequestDal
    {
        public Request Add(Request entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Request entity)
        {
            throw new NotImplementedException();
        }

        public Request Get(Expression<Func<Request, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Request> GetAll(Expression<Func<Request, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Request Update(Request entity)
        {
            throw new NotImplementedException();
        }
    }
}
