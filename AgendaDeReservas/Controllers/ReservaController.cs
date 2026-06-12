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
    public IActionResult Create ()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(string NomeCliente)
    {
       var novaReserva = new Reserva
       {
              Id = 3,
              NomeCliente = NomeCliente,
              Telefone = 0,
              DataReserva = DateTime.Now,
              TipoDeEvento = "",
              Observacao = "",
              Horario = ""
       };
             ListaReserva.Add(novaReserva);
             return RedirectToAction("Index");
    }
}
