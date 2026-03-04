using Google.Cloud.Firestore;

namespace SugarEveSystem.Models
{
    [FirestoreData]
    public class Cotizacion
    {
        public string Id { get; set; }

        [FirestoreProperty]
        public string NombreCliente { get; set; }

        [FirestoreProperty]
        public string TipoEvento { get; set; }

        [FirestoreProperty]
        public string TipoServicio { get; set; } // Ej. "Backdrops", "MesaDulces", etc.

        [FirestoreProperty]
        public string FechaEvento { get; set; } // Formato YYYY-MM-DD

        [FirestoreProperty]
        public double MontoCotizado { get; set; }

        [FirestoreProperty]
        public string Estado { get; set; } // "Pendiente", "Confirmado", "Cancelado"

        [FirestoreProperty]
        public string Detalles { get; set; }

        // Calculado en tiempo de ejecución, no persiste en Firestore
        public DateTime? FechaEventoDate =>
            DateTime.TryParse(FechaEvento, out var d) ? d : (DateTime?)null;

        public int? DiasRestantes =>
            FechaEventoDate.HasValue
                ? (int)(FechaEventoDate.Value.Date - DateTime.Today).TotalDays
                : (int?)null;

        public bool EsProximo => DiasRestantes.HasValue && DiasRestantes >= 0 && DiasRestantes <= 7;
        public bool EsUrgente => DiasRestantes.HasValue && DiasRestantes >= 0 && DiasRestantes <= 2;
    }
}
