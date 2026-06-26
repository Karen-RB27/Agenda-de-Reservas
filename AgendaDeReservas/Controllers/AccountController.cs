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

        [HttpPost]
        public IActionResult Login(string Email, string Senha)
        {
            var usuario = _context.Usuarios
                .FirstOrDefault(u => u.Email == Email && u.Senha == Senha);

            if (usuario != null)
            {
                return RedirectToAction("Index", "Reserva");
            }

            ViewBag.Mensagem = "E-mail ou senha inválidos.";

            return View();
        }

        public IActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastro(string Nome, string Email, string Senha)
        {
            var usuario = new Usuario
            {
                Nome = Nome,
                Email = Email,
                Senha = Senha
            };

            _context.Usuarios.Add(usuario);
            _context.SaveChanges();

            return RedirectToAction("Login");
        }
    }
}