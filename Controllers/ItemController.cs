using _1.InAndOut_01.Data;
using _1.InAndOut_01.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace _1.InAndOut_01.Controllers
{
    public class ItemController : Controller
    {
        private readonly ApplicationDbContext _db;

        public ItemController(ApplicationDbContext db) 
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Item> objList = _db.Items;
            return View(objList);
        }
    }
}
