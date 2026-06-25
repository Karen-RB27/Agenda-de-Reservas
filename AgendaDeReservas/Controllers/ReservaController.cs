using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using AgendaDeReservas.Models;
using AgendaDeReservas.DATA;
using Microsoft.EntityFrameworkCore;

namespace AgendaDeReservas.Controllers;

public class ReservaController : Controller
{
    private readonly AppDbContext _context;

    public ReservaController(AppDbContext context)
    {
        _context = context;
    }

    public string Observacao { get; private set; }
    public string TipoDeEvento { get; private set; }

    public IActionResult Index()
   {
       var reservas = _context.Reservas.ToList();
       return View(reservas);
   }
    public IActionResult Create ()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(string NomeCliente, int Telefone, DateTime DataReserva, string TipoDeEvento, string Observacoes)
    {
        var novaReserva = new Reserva
        {
            Id = ListaReserva.ObterTodas().Count + 1,
            NomeCliente = NomeCliente,
            Telefone = Telefone,
            DataReserva = DataReserva,
            TipoDeEvento = TipoDeEvento,
            Observacao = Observacoes
        };

        _context.Reservas.Add(novaReserva);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }

    public IActionResult Delete (int id)
    {
        ListaReserva.Delete(id);
        return RedirectToAction("Index");
    }

   public IActionResult Edit(int id)
    {
        var reserva = _context.Reservas.Find(id);

        if (reserva == null)
        {
            return Content("Reserva não encontrada");
        }
        return View(reserva);
    }

    [HttpPost]
    public IActionResult Edit(int Id, string NomeCliente, int Telefone, DateTime dateTime)
    {
        var reservaAtualizada = _context.Reservas.Find(Id);
        if (reservaAtualizada == null)
        {
            return Content("Reserva não encontrada");
        }
        
        reservaAtualizada.NomeCliente = NomeCliente;
        reservaAtualizada.Telefone = Telefone;
        reservaAtualizada.DataReserva = dateTime;
        reservaAtualizada.TipoDeEvento = TipoDeEvento;
        reservaAtualizada.Observacao = Observacao;

        _context.SaveChanges();
        return RedirectToAction("Index");
        
    }
}
    