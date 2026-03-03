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
        public string FechaEvento { get; set; } // Formato YYYY-MM-DD

        [FirestoreProperty]
        public double MontoCotizado { get; set; }

        [FirestoreProperty]
        public string Estado { get; set; } // "Pendiente", "Confirmado", "Cancelado"

        [FirestoreProperty]
        public string Detalles { get; set; }
    }
}
