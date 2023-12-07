using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace workout_helper_2.Models
{
	public class Workout
	{
        [Key]
        public int WorkOutId { get; set; }

        public string name { get; set; } = null!;

        public string? type { get; set; }

        public ICollection<UserWorkOutSchedule> UserWorkOutSchedules { get; set; } = null!;


    }
}

