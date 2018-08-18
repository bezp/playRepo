using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BeckonedPath.Library.Models;
using BeckonedPath.MvcClient.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BeckonedPath.MvcClient.Controllers
{
    public class HomeController : Controller
    {
        private readonly UserViewModel userViewModel = new UserViewModel();

        private readonly PlayDBContext _db;

        public HomeController(PlayDBContext playDBContext)
        {
            _db = playDBContext;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            ViewBag.PageTitle = userViewModel.PageTitle;
            ViewBag.asd = userViewModel;
            return View();
        }
    }
}
