using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace workout_helper_2.Models
{
	public class User
	{

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }

        public string name { get; set; } = null!;

		public string? email { get; set; }

	
	}
}

