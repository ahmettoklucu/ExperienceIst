using ExperienceIst.DataAccess.Abstract;

using ExperienceIst.Entities.Concrate;

using Microsoft.EntityFrameworkCore;

using System.Linq.Expressions;


namespace ExperienceIst.DataAccess.Concrate
{
    public class RequestDal : IRequestDal
    {
        private readonly ExperienceIstContext _context;

        public RequestDal(ExperienceIstContext context)
        {
            _context = context;
        }
        public Request Add(Request entity)
        {

            var addedEntity = _context.Entry(entity);
            addedEntity.State = EntityState.Added;
            _context.SaveChanges();
            return entity;

        }

        public void Delete(Request entity)
        {

            var deletedEntity = _context.Entry(entity);
            deletedEntity.State = EntityState.Deleted;
            _context.SaveChanges();

        }

        public Request Get(Expression<Func<Request, bool>> filter)
        {

            return _context.Set<Request>().SingleOrDefault(filter);

        }

        public List<Request> GetAll(Expression<Func<Request, bool>> filter = null)
        {

            return filter == null
                ? _context.Set<Request>().ToList()
                : _context.Set<Request>().Where(filter).ToList();

        }

        public Request Update(Request entity)
        {

            var updatedEntity = _context.Entry(entity);
            updatedEntity.State = EntityState.Modified;
            _context.SaveChanges();
            return entity;

        }
    }
}
