using Buoi4_1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NuGet.Packaging;
using System.Collections;

namespace Buoi4_1.Controllers
{
    public class NhanVienController : Controller
    {
        static public List<NhanVien> a = new List<NhanVien>
        {
            new NhanVien
            {
                MaNV = 1,
                HoTen = "Việt Anh",
                a = new NgaySinh {Ngay = 25, Thang = 6, Nam = 2004},
                GioiTinh = "Nam",
                SoDT = 0971975053,
                HSLuong = 4.33m,
                Luong = 1084235,
                TenPhong = "IT"
            },
            new NhanVien
            {
                MaNV = 2,
                HoTen = "Em Xinh",
                a = new NgaySinh {Ngay = 6, Thang = 4, Nam = 1995},
                GioiTinh = "Nữ",
                SoDT = 0974456424,
                HSLuong = 6.78m,
                Luong = 8022378,
                TenPhong = "IT"
            },
            new NhanVien
            {
                MaNV = 3,
                HoTen = "Nguyen Van C",
                a = new NgaySinh {Ngay = 1, Thang = 4, Nam = 2014},
                GioiTinh = "Nam",
                SoDT = 0945456424,
                HSLuong = 3.98m,
                Luong = 1234538,
                TenPhong = "Văn Phòng"
            },
            new NhanVien
            {
                MaNV = 4,
                HoTen = "Nguyen Thị D",
                a = new NgaySinh {Ngay = 23, Thang = 11, Nam = 1995},
                GioiTinh = "Nam",
                SoDT = 0954456424,
                HSLuong = 10.12m,
                Luong = 12344338,
                TenPhong = "Văn Phòng"
            },
            new NhanVien
            {
                MaNV = 5,
                HoTen = "Trần Văn E",
                a = new NgaySinh {Ngay = 23, Thang = 5, Nam = 2011},
                GioiTinh = "Nam",
                SoDT = 0951254424,
                HSLuong = 8.74m,
                Luong = 1231238,
                TenPhong = "IT"
            },
        };
        // Tìm kiếm và hiển thị nhân viên có giới tính nữ
        public IActionResult TimKiem1()
        {
            return View(a);
        }

        // Tính tổng lương của các nhân viên của 1 phòng với tên phòng nhập vào textbox
        public IActionResult Tong2()
        {
            return View();
        }
        public IActionResult Tong2_1(string s)
        {
            var NV = new List<NhanVien>();
            foreach(NhanVien temp in a)
            {
                if(temp.TenPhong == s) 
                    NV.Add(temp);
            }
            if(NV.Any())
            {
                float TongLuong = NV.Sum(m => m.Luong);
                ViewBag.Tong = TongLuong;   
                ViewBag.s = s;
                return View();
            }
            else
            {
                ViewBag.ErrorMessage = "Phòng ban không tồn tại. Vui lòng nhập lại.";
                return View("Tong2");
            }    
        }

        //  Tìm kiếm và hiển thị nhân viên của một 1 phòng với tên phòng nhập vào textbox
        public IActionResult Timkiem3()
        {
            return View();
        }
        public IActionResult Timkiem3_1(string s)
        {
            var NV = new List<NhanVien>();
            foreach (NhanVien temp in a)
            {
                if (temp.TenPhong == s)
                    NV.Add(temp);
            }
            if (NV.Any())
            {
                ViewBag.s = s;
                return View(NV);
            }
            else
            {
                ViewBag.ErrorMessage = "Phòng ban không tồn tại. Vui lòng nhập lại.";
                return View("Tong2");
            }
        }

        // GET: NhanVienController
        public ActionResult Index()
        {
            return View(a);
        }

        // GET: NhanVienController/Details/5
        public ActionResult Details(int id)
        {
            NhanVien NV = a.FirstOrDefault(m => m.MaNV == id);
            if(NV == null)
            {
                return NotFound();
            }    
            return View(NV);
        }

        // GET: NhanVienController/Create
        public ActionResult Create()
        {
            return View();
        }
        // POST: NhanVienController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(NhanVien CreateNV)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    CreateNV.MaNV = a.Max(x => x.MaNV) + 1;
                    a.Add(CreateNV);
                    return RedirectToAction("Index");
                }
                return View(CreateNV);
            }
            catch
            {
                return View();
            }
        }
        // GET: NhanVienController/Edit/5
        public ActionResult Edit(int id)
        {
            NhanVien NVEdit = a.FirstOrDefault(u => u.MaNV == id);
            if (NVEdit == null)
            {
                return NotFound();
            }    
            return View(NVEdit);
        }

        // POST: NhanVienController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, NhanVien b)
        {
            try
            {
                NhanVien EditNV = a.FirstOrDefault(u =>u.MaNV == id);
                if(EditNV == null)
                {
                    return NotFound();
                }
                else
                {
                    EditNV.HoTen = b.HoTen;
                    EditNV.a = b.a;
                    EditNV.GioiTinh = b.GioiTinh;
                    EditNV.SoDT = b.SoDT;
                    EditNV.HSLuong = b.HSLuong;
                    EditNV.Luong = b.Luong;
                    EditNV.TenPhong = b.TenPhong;
                    return RedirectToAction(nameof(Index));
                }
            }
            catch
            {
                return View();
            }
        }

        // GET: NhanVienController/Delete/5
        public ActionResult Delete(int id)
        {
            NhanVien DeleteNV = a.FirstOrDefault(v => v.MaNV == id);
            if(DeleteNV == null)
            {
                return NotFound();
            }    
            return View(DeleteNV);
        }

        // POST: NhanVienController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, NhanVien NV)
        {
            NhanVien DeleteNV = a.FirstOrDefault(v => v.MaNV == id);
            try
            {
                if (DeleteNV == null)
                {
                    return NotFound();
                }
                else
                {
                    a.Remove(DeleteNV);
                    return RedirectToAction(nameof(Index));
                }    
                
            }
            catch
            {
                return View(DeleteNV);
            }
        }
    }
}
