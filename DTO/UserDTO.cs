using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace workout_helper_2.DTO
{
    public partial class User
    {

        public int UserId { get; set; }

        public string name { get; set; } = null!;

        public string? email { get; set; }


    }
}

