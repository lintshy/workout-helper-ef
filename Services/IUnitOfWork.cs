using workout_helper_2.Models;
using workout_helper_2.Services;

namespace workout_helper_2.Services
{
    public interface IUnitOfWork
    {
        IRepository<User> User { get; }
        IRepository<UserWorkOutSchedule> UserWorkOutSchedule { get; }
        IRepository<Workout> Workout { get; }
      
        void Commit();
        void Dispose();
    }
}
