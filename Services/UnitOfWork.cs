using workout_helper_2.Data;
using workout_helper_2.Models;
using workout_helper_2.Services;

namespace workout_helper_2.Services
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly WorkoutHelperContext context;
        public IRepository<User> User { get; private set; }
        public IRepository<Workout> Workout { get; private set; }
        public IRepository<UserWorkOutSchedule> UserWorkOutSchedule { get; private set; }
        

        public UnitOfWork(WorkoutHelperContext _context)
        {
            context = _context;
            User = new Repository<User>(context);
            Workout = new Repository<Workout>(context);
            UserWorkOutSchedule = new Repository<UserWorkOutSchedule>(context);
           
        }

        public void Commit()
        {
            context.SaveChanges();
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}
