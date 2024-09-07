using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using MilkteaForFree.Bll.UserService;
using MilkteaForFree.DAL.Models;

namespace MilkteaForFree.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private UserService userService = new();
        [HttpGet]
        public IActionResult GetAll()
        {
            List<User> na = userService.GetAll;
            return Ok(na);
        }

        [HttpPost]
        public IActionResult Add()
        {
            User user = new User() {UserName = "Johnfy", Password = "@12", UserPhone = "0111222" };
            userService.Add(user);
            return Ok(user);
        }

        [HttpGet]
        [Route("{id:int}")]
        public IActionResult GetId(int id)
        {
            var user =  userService.GetUser(id);
            if (user == null) return NotFound();
            return Ok(user);
        }

        [HttpPut]
        [Route("{id:int}")]
        public IActionResult Put(int id) 
        { 
            var user = userService.GetUser(id);
            if (user == null) return NotFound();
            user.UserName = "11";
            userService.Update(user);
            return Ok(user);
        }

        [HttpDelete]
        [Route("{id:int}")]
        public IActionResult Delete(int id) {
            var user = userService.GetUser(id);
            if (user == null) return NotFound();
            userService.Dellete(user);
            return Ok(user);
        }
    }
}
