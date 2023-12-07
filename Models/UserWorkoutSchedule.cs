using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace workout_helper_2.Models
{
    public class UserWorkOutSchedule
    {
        [Key]
        public int UserWorkOrderScheduleId { get; set; }

        public int WorkoutId { get; set; }

        public int userId { get; set; }

        public int numberOfReps { get; set; }

        public int dayOftheWeek { get; set; }


    }
}

