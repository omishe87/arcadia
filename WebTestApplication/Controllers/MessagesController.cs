using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebTest.Controllers
{
    public class MessagesController : Controller
    {
        private readonly WebTestApplication.Models.CrudExampleContext _context;

        public MessagesController(WebTestApplication.Models.CrudExampleContext context)
        {
            _context = context;
        }

        public ActionResult ListMessages()
        {
            var result = _context.Messages.ToList();
            return View(result);
        }

        public ActionResult Details(int id)
        {
            var result = _context.Messages.Where(m => m.Id == id).FirstOrDefault();
            return View(result);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(IFormCollection data)
        {
            try
            {
                var message = new WebTestApplication.Models.Messages
                {
                    Date = DateTime.Now,
                    Message = data["Message"]
                };

                _context.Messages.Add(message);
                _context.SaveChanges();

                return RedirectToAction(nameof(ListMessages));
            }
            catch
            {
                return View();
            }
        }
    }
}