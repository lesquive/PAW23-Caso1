using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace frontend_razor.Pages
{
    public class ReservasModel : PageModel
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public ReservasModel(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public List<Reserva> Reservas { get; private set; } = new List<Reserva>();
        public string ErrorMessage { get; private set; }

        public async Task OnGetAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetFromJsonAsync<List<Reserva>>("https://localhost:7059/api/reservas");

            if (response != null)
            {
                Reservas = response;
            } else
            {
               ErrorMessage = "Error!";
            }
        }

    }


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
