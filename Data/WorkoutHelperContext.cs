using Microsoft.EntityFrameworkCore;

using workout_helper_2.Models;

namespace workout_helper_2.Data;

public class WorkoutHelperContext : DbContext
{
	public DbSet<User> Users { get; set; } = null!;

	public DbSet<UserWorkOutSchedule> UserWorkOutSchedules { get; set; } = null!;

	public DbSet<Workout> Workouts { get; set; } = null!;

    public WorkoutHelperContext(DbContextOptions<WorkoutHelperContext> options)
        : base(options)
    {
    }
}

