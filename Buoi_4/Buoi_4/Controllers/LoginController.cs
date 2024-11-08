using Buoi_4.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Buoi_4.Controllers
{
    public class LoginController : Controller
    {
        // GET: LoginController
        static List<Login> a = new List<Login>
        {
            new Login
            {
                ID = 1,
                Name = "Việt Anh",
                Email = "vanh2004@gmail.com",
                Age = 20,
                Password = "vanh2004",
                ReEnterPassword = "vanh2004",
            },
            new Login
            {
                ID = 2,
                Name = "Văn Huy",
                Email = "huyhuy2k4@gmail.com",
                Age = 20,
                Password = "huy2004",
                ReEnterPassword = "huy2004",
            }
        };
        public ActionResult Index()
        {
            return View(a);
        }

        // GET: LoginController/Details/5
        public ActionResult Details(int id)
        {
            Login log = a.FirstOrDefault(u => u.ID == id);
            if(log == null)
            {
                return NotFound();
            }    
            return View(log);
        }

        // GET: LoginController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LoginController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Login CreateLog)
        {
            try
            {
                CreateLog.Age = DateTime.Today.Year - CreateLog.BirthDay.Year;
                if (ModelState.IsValid)
                {
                    CreateLog.ID = a.Max(u => u.ID) + 1;
                    a.Add(CreateLog);
                    return RedirectToAction(nameof(Index));
                }
                return View(CreateLog);
            }
            catch
            {
                return View();
            }
        }

        // GET: LoginController/Edit/5
        public ActionResult Edit(int id)
        {
            Login log = a.FirstOrDefault(u => u.ID == id);
            if (log == null)
            {
                return NotFound();
            }
            return View(log);
        }

        // POST: LoginController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Login editLogin)
        {
            try
            {
                Login existingLogin = a.FirstOrDefault(u => u.ID == id);
                if (existingLogin == null)
                {
                    return NotFound();
                }
                else
                {
                    existingLogin.Name = editLogin.Name;
                    existingLogin.Age = DateTime.Today.Year - editLogin.BirthDay.Year;
                    existingLogin.Email = editLogin.Email;
                    existingLogin.Password = editLogin.Password;
                    existingLogin.ReEnterPassword = editLogin.ReEnterPassword;
                    existingLogin.Gender = editLogin.Gender;
                    existingLogin.BirthDay = editLogin.BirthDay;
                    existingLogin.ClassName = editLogin.ClassName;
                    return RedirectToAction(nameof(Index));
                }
            }
            catch
            {
                return View(editLogin);
            }
        }

        // GET: LoginController/Delete/5
        public ActionResult Delete(int id)
        {
            Login DeleteLog = a.FirstOrDefault(u => u.ID == id);
            if (DeleteLog == null)
            {
                return NotFound();
            }
            return View(DeleteLog);
        }

        // POST: LoginController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Login log)
        {
            Login DeleteLog = a.FirstOrDefault(u => u.ID == id);
            try
            {
                if (DeleteLog == null)
                {
                    return NotFound();
                }
                else
                {
                    a.Remove(DeleteLog);
                    return RedirectToAction(nameof(Index));
                }
            }
            catch
            {
                return View(DeleteLog);
            }
        }
    }
}
