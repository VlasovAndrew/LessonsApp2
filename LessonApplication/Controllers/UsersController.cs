using BL;

using Interfaces;
using LessonApplication.Models.Users;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LessonApplication.Controllers
{
    public class UsersController : Controller
    {
        private IUsersBL _bl;
        public UsersController(IUsersBL bl)
        {
            _bl = bl;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Get(int id) {
            var user = _bl.GetById(id);

            if (user != null)
            {
                return View(new UserModel() { Id = user.Id, FullName = $"{user.Name} {user.Phone}" });
            }
            else {
                return View();
            }
            
        }

    }
}
