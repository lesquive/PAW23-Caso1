using backend.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tarea1.Controllers
{
    [Route("api/reservas")]
    [EnableCors("AllowLocalhost")]
    [ApiController]
    public class ReservasController : ControllerBase
    {
        private readonly ReservaDbContext _context;

        public ReservasController(ReservaDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        [EnableCors("AllowLocalhost")]
        public async Task<IActionResult> Get()
        {
            var reservas = await _context.Reservas.ToListAsync();
            return Ok(reservas);
        }

        [HttpGet("{id}", Name = "GetReserva")]
        [EnableCors("AllowLocalhost")]
        public async Task<IActionResult> Get(int id)
        {
            var reserva = await _context.Reservas.FindAsync(id);
            if (reserva == null)
            {
                return NotFound();
            }
            return Ok(reserva);
        }

        [HttpPost]
        [EnableCors("AllowLocalhost")]
        public async Task<IActionResult> Post([FromBody] Reserva reserva)
        {
            _context.Reservas.Add(reserva);
            await _context.SaveChangesAsync();
            return CreatedAtRoute("GetReserva", new { id = reserva.Id }, reserva);
        }

        [HttpPost("{id}")]
        [EnableCors("AllowLocalhost")]
        public async Task<IActionResult> Put(int id, [FromBody] Reserva reserva)
        {

            var existingReserva = _context.Reservas.Find(id);

            if (existingReserva == null)
            {
                return NotFound();
            }

            if (reserva.Nombre != null)
            {
                existingReserva.Nombre = reserva.Nombre;
            }

            if (reserva.Apellido != null)
            {
                existingReserva.Apellido = reserva.Apellido;
            }

            if (reserva.Teléfono != null)
            {
                existingReserva.Teléfono = reserva.Teléfono;
            }

            if (reserva.Email != null)
            {
                existingReserva.Email = reserva.Email;
            }

            if (reserva.Dirección != null)
            {
                existingReserva.Dirección = reserva.Dirección;
            }

            if (reserva.NumPersonas != null)
            {
                existingReserva.NumPersonas = reserva.NumPersonas;
            }

            if (reserva.Fecha != null)
            {
                existingReserva.Fecha = reserva.Fecha;
            }

            if (reserva.Hora != null)
            {
                existingReserva.Hora = reserva.Hora;
            }

            if (reserva.NumMesa != null)
            {
                existingReserva.NumMesa = reserva.NumMesa;
            }

            _context.Entry(existingReserva).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.Reservas.Any(r => r.Id == id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }


        [HttpDelete("{id}")]
        [EnableCors("AllowLocalhost")]
        public async Task<IActionResult> Delete(int id)
        {
            var reserva = await _context.Reservas.FindAsync(id);
            if (reserva == null)
            {
                return NotFound();
            }

            _context.Reservas.Remove(reserva);
            await _context.SaveChangesAsync();

            return Ok(reserva);
        }
    }
}
