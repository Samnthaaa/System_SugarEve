using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SugarEveSystem.Models;
using SugarEveSystem.Services;
using Google.Cloud.Firestore;

namespace SugarEveSystem.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    private readonly FirebaseConfig _firebaseConfig;

    public List<Cotizacion> AlertasProximas { get; set; } = new();
    public List<Cotizacion> TodasCotizaciones { get; set; } = new();
    public int TotalEventesMes { get; set; }
    public int TotalConfirmadas { get; set; }
    public int TotalPendientes { get; set; }

    public IndexModel(ILogger<IndexModel> logger, FirebaseConfig firebaseConfig)
    {
        _logger = logger;
        _firebaseConfig = firebaseConfig;
    }

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
                    TodasCotizaciones.Add(item);
                }
            }
        }
        else
        {
            // Datos de muestra mientras Firebase no está configurado
            TodasCotizaciones = DatosEjemplo.ObtenerCotizaciones();
        }

        var hoy = DateTime.Today;
        AlertasProximas = TodasCotizaciones
            .Where(c => c.Estado == "Confirmado" && c.EsProximo)
            .OrderBy(c => c.DiasRestantes)
            .ToList();

        TotalEventesMes = TodasCotizaciones
            .Count(c => c.FechaEventoDate.HasValue &&
                        c.FechaEventoDate.Value.Year == hoy.Year &&
                        c.FechaEventoDate.Value.Month == hoy.Month);

        TotalConfirmadas = TodasCotizaciones.Count(c => c.Estado == "Confirmado");
        TotalPendientes = TodasCotizaciones.Count(c => c.Estado == "Pendiente");
    }
}
