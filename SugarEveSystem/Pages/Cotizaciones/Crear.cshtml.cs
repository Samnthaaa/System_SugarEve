using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SugarEveSystem.Models;
using SugarEveSystem.Services;

namespace SugarEveSystem.Pages.Cotizaciones
{
    public class CrearModel : PageModel
    {
        private readonly FirebaseConfig _firebaseConfig;

        [BindProperty]
        public Cotizacion Cotizacion { get; set; } = new Cotizacion();

        public string ErrorMessage { get; set; }

        public CrearModel(FirebaseConfig firebaseConfig)
        {
            _firebaseConfig = firebaseConfig;
            // Set default date to today
            Cotizacion.FechaEvento = DateTime.Today.ToString("yyyy-MM-dd");
            Cotizacion.Estado = "Pendiente";
        }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var db = _firebaseConfig.GetFirestoreDb();
            if (db == null)
            {
                ErrorMessage = "Error: La conexión a Firebase no está configurada correctamente.";
                return Page();
            }

            try
            {
                var collection = db.Collection("cotizaciones");
                await collection.AddAsync(Cotizacion);
                return RedirectToPage("./Index");
            }
            catch (Exception ex)
            {
                ErrorMessage = $"Error al guardar en Firebase: {ex.Message}";
                return Page();
            }
        }
    }
}
