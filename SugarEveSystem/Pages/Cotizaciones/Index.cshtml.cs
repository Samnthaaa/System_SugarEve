using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Google.Cloud.Firestore;
using SugarEveSystem.Models;
using SugarEveSystem.Services;

namespace SugarEveSystem.Pages.Cotizaciones
{
    public class IndexModel : PageModel
    {
        private readonly FirebaseConfig _firebaseConfig;

        public List<Cotizacion> Cotizaciones { get; set; } = new();
        public List<Cotizacion> CotizacionesFiltradas { get; set; } = new();
        public List<Cotizacion> AlertasProximas { get; set; } = new();

        [BindProperty(SupportsGet = true)]
        public string Busqueda { get; set; }

        [BindProperty(SupportsGet = true)]
        public string FiltroServicio { get; set; }

        [BindProperty(SupportsGet = true)]
        public string FiltroEstado { get; set; }

        [BindProperty(SupportsGet = true)]
        public string FiltroFecha { get; set; }

        public IndexModel(FirebaseConfig firebaseConfig) => _firebaseConfig = firebaseConfig;

        public async Task OnGetAsync()
        {
            var db = _firebaseConfig.GetFirestoreDb();
            if (db != null)
            {
                Query query = db.Collection("cotizaciones");
                QuerySnapshot snapshot = await query.GetSnapshotAsync();
                foreach (var doc in snapshot.Documents)
                {
                    if (doc.Exists)
                    {
                        var item = doc.ConvertTo<Cotizacion>();
                        item.Id = doc.Id;
                        Cotizaciones.Add(item);
                    }
                }
            }
            else
            {
                Cotizaciones = DatosEjemplo.ObtenerCotizaciones();
            }

            // Alertas: próximas en 7 días y confirmadas
            AlertasProximas = Cotizaciones
                .Where(c => c.Estado == "Confirmado" && c.EsProximo)
                .OrderBy(c => c.DiasRestantes)
                .ToList();

            // Aplicar filtros
            CotizacionesFiltradas = Cotizaciones.AsQueryable()
                .Where(c => string.IsNullOrEmpty(Busqueda) ||
                            c.NombreCliente.Contains(Busqueda, StringComparison.OrdinalIgnoreCase) ||
                            c.TipoEvento.Contains(Busqueda, StringComparison.OrdinalIgnoreCase) ||
                            (c.Detalles ?? "").Contains(Busqueda, StringComparison.OrdinalIgnoreCase))
                .Where(c => string.IsNullOrEmpty(FiltroServicio) || c.TipoServicio == FiltroServicio)
                .Where(c => string.IsNullOrEmpty(FiltroEstado) || c.Estado == FiltroEstado)
                .Where(c => string.IsNullOrEmpty(FiltroFecha) || c.FechaEvento == FiltroFecha)
                .OrderBy(c => c.FechaEvento)
                .ToList();
        }
    }
}
