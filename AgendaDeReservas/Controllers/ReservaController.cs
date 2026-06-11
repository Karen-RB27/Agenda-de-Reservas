using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using AgendaDeReservas.Models;

namespace AgendaDeReservas.Controllers;

public class ReservaController : Controller
{
    public IActionResult Index()
   {
       var reservas = ListaReserva.ObterTodas();
       return View(reservas);
   }
}
