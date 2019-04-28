using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NgAlainDemo.Models;

namespace NgAlainDemo.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        [HttpPost]
        public IActionResult Login(LoginModel model)
        {
            if (model?.userName != "admin" || model?.password != "admin")
            {
                return Ok(new { msg = "Invalid username or password（admin/admin）" });
            }
            return Ok(new
            {
                msg = "ok", user = new
                {
                    token = "123456789",
                        name = model.userName,
                        email = "${data.userName}@qq.com",
                        id = 10000,
                        time = DateTime.Now,
                }
            });
        }
    }
}
