using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SugarEveSystem.Models;
using SugarEveSystem.Services;

namespace SugarEveSystem.Pages.Inventario
{
    public class CrearModel : PageModel
    {
        private readonly FirebaseConfig _firebaseConfig;

        [BindProperty]
        public InventarioItem Item { get; set; } = new InventarioItem();

        public string ErrorMessage { get; set; }

        public CrearModel(FirebaseConfig firebaseConfig)
        {
            _firebaseConfig = firebaseConfig;
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
                var collection = db.Collection("inventario");
                await collection.AddAsync(Item);
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
