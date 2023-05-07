using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatingApp.Data.Context;
using DatingApp.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.WebApi.Controllers
{
    public class UsersController : BaseApiController
    {
        private readonly DatingAppContext _ctx;

        public UsersController(DatingAppContext ctx)
        {
            _ctx = ctx;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUser>>> GetUsersAsync()
        {
            var users = await _ctx.Users.ToListAsync();

            return Ok(users);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<AppUser>> GetUser(int id)
        {
            var user = await _ctx.Users.FindAsync(id);
            if (user == null) return NotFound("user not found");

            return Ok(user);
        }
    }
}