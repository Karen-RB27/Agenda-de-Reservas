namespace AgendaDeReservas.Models

{
    public class Reserva
    {
        public int Id { get; set; }
        public string NomeCliente { get; set; }
        public int Telefone { get; set; }
        public DateTime DataReserva { get; set; }
        public string TipoDeEvento { get; set; }
        public string Observacao { get; set; }
        
    }
}