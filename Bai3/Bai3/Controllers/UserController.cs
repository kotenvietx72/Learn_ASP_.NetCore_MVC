using Bai3.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bai3.Controllers
{
    public class UserController : Controller
    {
        static List<User> user = new List<User>();
        // GET: UserController
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Index1()
        {
            User user1 = new User()
            {
                Id = 1,
                Name = "Việt Anh",
                Address = "Hà Nội",
                Email = "vanh@gmail.com",
            };
            ViewBag.User1 = user1;
            return View();
        }
        public ActionResult Index2()
        {
            List<User> users = new List<User>()
            {
                new User
                {
                    Id = 2,
                    Name = "Huy",
                    Address = "Hà Nội",
                    Email = "huy@gmail.com",
                },
                new User
                {
                    Id = 3,
                    Name = "Tú",
                    Address = "Thái Bình",
                    Email = "tu@gmail.com",
                },
            };
            User user2 = new User { Id = 4, Name = "Ngọc", Address = "Thái Bình", Email = "ngoc@gmail.com" };
            users.Add(user2);
            ViewBag.users = users;
            return View();
        }
        public ActionResult Index3()
        {
            List<User> users = new List<User>()
            {
                new User
                {
                    Id = 2,
                    Name = "Huy",
                    Address = "Hà Nội",
                    Email = "huy@gmail.com",
                },
                new User
                {
                    Id = 3,
                    Name = "Tú",
                    Address = "Thái Bình",
                    Email = "tu@gmail.com",
                },
            };
            User user2 = new User { Id = 4, Name = "Ngọc", Address = "Thái Bình", Email = "ngoc@gmail.com" };
            users.Add(user2);
            return View(users);
        }
        public ActionResult Index4()
        {
            User user1 = new User()
            {
                Id = 1,
                Name = "Việt Anh",
                Address = "Hà Nội",
                Email = "vanh@gmail.com",
            };
            return View(user1);
        }
        [HttpPost]
        public ActionResult Index4(User user)
        {
            string msg = "Id: " + user.Id + "\nName: " + user.Name + "\nAddress: " + user.Address + "\nEmail: " + user.Email;
            return Content(msg);
        }
        public ActionResult Index5()
        {
            List<User> users = new List<User>()
            {
                new User
                {
                    Id = 2,
                    Name = "Huy",
                    Address = "Hà Nội",
                    Email = "huy@gmail.com",
                },
                new User
                {
                    Id = 3,
                    Name = "Tú",
                    Address = "Thái Bình",
                    Email = "tu@gmail.com",
                },
            };
            User user2 = new User { Id = 4, Name = "Ngọc", Address = "Thái Bình", Email = "ngoc@gmail.com" };
            users.Add(user2);
            return View(users);
        }
        // GET: UserController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: UserController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UserController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UserController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UserController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UserController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UserController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
