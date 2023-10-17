using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace frontend_razor.Pages
{
    public class CrearReservaModel : PageModel
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly ILogger<CrearReservaModel> _logger;

        [BindProperty]
        public Reserva NewReserva { get; set; }

        public CrearReservaModel(IHttpClientFactory httpClientFactory, ILogger<CrearReservaModel> logger)
        {
            _httpClientFactory = httpClientFactory;
            _logger = logger;
        }


        public async Task<IActionResult> OnPostAsync()
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var client = _httpClientFactory.CreateClient();

                    var response = await client.PostAsJsonAsync("https://localhost:7059/api/reservas", NewReserva);

                    if (response.IsSuccessStatusCode)
                    {
                        return RedirectToPage("/Reservas");
                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, "No se puede crear una reserva :( .");
                        return Page();
                    }
                }
                else
                {
                    return Page();
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Hubo un error :(");
                ModelState.AddModelError(string.Empty, "Hubo un error :(");
                return Page();
            }
        }
    }
}
