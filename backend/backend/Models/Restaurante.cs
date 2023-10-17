using System;
namespace backend.Models
{
    public class Reserva
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? Teléfono { get; set; }
        public string? Email { get; set; }
        public string? Dirección { get; set; }
        public int? NumPersonas { get; set; }
        public string? Fecha { get; set; }
        public string? Hora { get; set; }
        public int? NumMesa { get; set; }
    }
}

