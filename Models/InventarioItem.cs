using Google.Cloud.Firestore;

namespace SugarEveSystem.Models
{
    [FirestoreData]
    public class InventarioItem
    {
        public string Id { get; set; }

        [FirestoreProperty]
        public string Codigo { get; set; }

        [FirestoreProperty]
        public string Descripcion { get; set; }

        [FirestoreProperty]
        public string TipoMaterial { get; set; } // "Globo" o "Base"

        [FirestoreProperty]
        public int CantidadDisponible { get; set; }

        [FirestoreProperty]
        public string FotografiaUrl { get; set; }
    }
}
