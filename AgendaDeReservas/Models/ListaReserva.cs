using System;
using System.Collections.Generic;

namespace AgendaDeReservas.Models
{
    public static class ListaReserva
    {
        private static List<Reserva> reservas = new List<Reserva>
        {
            new Reserva
            {
                Id = 1,
                NomeCliente = "Karen Rocha",
                Telefone = 991782199,
                DataReserva = DateTime.Parse("2026-10-27"),
                TipoDeEvento = "Aniversário",
                Observacao = "50 pessoas",
                Horario = "12:00"
            },

            new Reserva
            {
                Id = 2,
                NomeCliente = "Kauany Brigagão",
                Telefone = 993056052,
                DataReserva = DateTime.Parse("2026-10-28"),
                TipoDeEvento = "Aniversário",
                Observacao = "100 pessoas",
                Horario = "20:00"
            }
        };

        public static List<Reserva> ObterTodas()
        {
            return reservas;
        }

        public static void Add (Reserva reserva)
        {
            reservas.Add(reserva);
        }
    }
}