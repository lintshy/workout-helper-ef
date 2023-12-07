using System;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Security.Claims;
using workout_helper_2.Models;
using workout_helper_2.Data;


namespace workout_helper_2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController: ControllerBase
	{
		private readonly ILogger<UserController> logger;
        private readonly WorkoutHelperContext dbContext;
		public UserController(ILogger<UserController> _logger, WorkoutHelperContext _dbContext)
		{
			logger = _logger;
            dbContext = _dbContext;
		}
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(IQueryable<User>), (int)HttpStatusCode.OK)]
        public ActionResult Get(int id)
        {

            var value = dbContext.Users.Where(p => p.UserId == id);
            return Ok(value);
        }
    }
}

