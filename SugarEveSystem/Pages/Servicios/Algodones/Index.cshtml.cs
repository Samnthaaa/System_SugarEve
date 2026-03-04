using Microsoft.AspNetCore.Mvc.RazorPages;
using Google.Cloud.Firestore;
using SugarEveSystem.Models;
using SugarEveSystem.Services;

namespace SugarEveSystem.Pages.Servicios.Algodones
{
    public class IndexModel : PageModel
    {
        private readonly FirebaseConfig _firebaseConfig;
        public List<ServicioChecklist> Servicios { get; set; } = new();
        public List<Cotizacion> Cotizaciones { get; set; } = new();
        public const string Tipo = "Algodones";

        public IndexModel(FirebaseConfig firebaseConfig) => _firebaseConfig = firebaseConfig;

        public async Task OnGetAsync()
        {
            var db = _firebaseConfig.GetFirestoreDb();
            if (db != null)
            {
                var snapChk = await db.Collection("checklists").WhereEqualTo("TipoServicio", Tipo).GetSnapshotAsync();
                foreach (var doc in snapChk.Documents)
                    if (doc.Exists) { var x = doc.ConvertTo<ServicioChecklist>(); x.Id = doc.Id; Servicios.Add(x); }

                var snapCot = await db.Collection("cotizaciones").WhereEqualTo("TipoServicio", Tipo).GetSnapshotAsync();
                foreach (var doc in snapCot.Documents)
                    if (doc.Exists) { var x = doc.ConvertTo<Cotizacion>(); x.Id = doc.Id; Cotizaciones.Add(x); }
            }
            else
            {
                Servicios = DatosEjemplo.ObtenerChecklists().Where(c => c.TipoServicio == Tipo).ToList();
                Cotizaciones = DatosEjemplo.ObtenerCotizaciones().Where(c => c.TipoServicio == Tipo).ToList();
            }
        }
    }
}
