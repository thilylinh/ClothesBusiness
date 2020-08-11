using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebBanQuanAo.DataContext;

namespace WebBanQuanAo.Controllers
{
    public class HomeController : Controller
    {
        private readonly BusinessContext _context;
        public HomeController(BusinessContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var list = _context.Products.AsNoTracking();
            return View(list.ToList());
        }
    }
}