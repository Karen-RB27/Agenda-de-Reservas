using AgendaDeReservas.DATA;
using AgendaDeReservas.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace AgendaDeReservas.Controllers
{
    public class AccountController : Controller
    {
        private readonly AppDbContext _context;

        public AccountController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Cadastro()
        {
            return View();
        }
    }
}