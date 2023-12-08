using System;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Security.Claims;
using workout_helper_2.Models;
using workout_helper_2.Data;
using workout_helper_2.Services;


namespace workout_helper_2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController: ControllerBase
	{
		private readonly ILogger<UserController> logger;
        private readonly IUnitOfWork unitOfWork;
        private readonly IB2BService b2BService;
        
		public UserController(ILogger<UserController> _logger, IUnitOfWork _unitOfWork, IB2BService _b2BService)
		{
			logger = _logger;
            unitOfWork = _unitOfWork;
            b2BService = _b2BService;
		}
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(IQueryable<User>), (int)HttpStatusCode.OK)]
        public ActionResult Get(int id)
        {

            var value = unitOfWork.User.Get(id);
            return Ok(value);
        }

        [HttpGet("details")]
        [ProducesResponseType(typeof(DailyUserData), (int)HttpStatusCode.OK)]
        public async Task <ActionResult> GetUsersAndWeather()
        {
            var _weather = await b2BService.GetCurrentWeather();
            var _users = unitOfWork.User.GetAll();
            var result = new DailyUserData()
            {
                weather = _weather ,
                users = _users
            };
            return Ok(result);
        }

        [HttpPost]
        [ProducesResponseType(typeof(User), (int)HttpStatusCode.OK)]
        public ActionResult Post([FromBody] User user)
        {
            var newUser = new User()
            {
                email = user.email,
                name = user.name
            };
            var result = unitOfWork.User.Add(newUser);
            unitOfWork.Commit();
            return Ok();
        }
    }
}

