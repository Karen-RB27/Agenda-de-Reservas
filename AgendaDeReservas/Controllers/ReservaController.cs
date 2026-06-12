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
    public IActionResult Create(string NomeCliente, int Telefone)
    {
       var novaReserva = new Reserva
       {
              Id = ListaReserva.ObterTodas().Count +1,
              NomeCliente = NomeCliente,
              Telefone = Telefone,
              DataReserva = DateTime.Now,
              TipoDeEvento = "",
              Observacao = "",
       };
             ListaReserva.Add(novaReserva);
             return RedirectToAction("Index");
    }

    public IActionResult Delete (int id)
    {
        ListaReserva.Delete(id);
        return RedirectToAction("Index");
    }

    public IActionResult Edit(int id)
    {
    return Content($"Recebi o ID {id}");
    }
}
    