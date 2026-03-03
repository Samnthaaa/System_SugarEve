using Google.Cloud.Firestore;

namespace SugarEveSystem.Models
{
    [FirestoreData]
    public class ServicioChecklist
    {
        public string Id { get; set; }

        [FirestoreProperty]
        public string TituloServicio { get; set; } // Ej. "Barra de snacks"

        [FirestoreProperty]
        public string EventoAsociado { get; set; } // Nombre del evento o cliente

        [FirestoreProperty]
        public string Responsable { get; set; }

        [FirestoreProperty]
        public string Estado { get; set; } // "Preparación", "En tránsito", "Montaje", "Finalizado"

        [FirestoreProperty]
        public bool ConfirmacionFinal { get; set; }

        [FirestoreProperty]
        public List<CheckItem> Materiales { get; set; }
    }

    [FirestoreData]
    public class CheckItem
    {
        [FirestoreProperty]
        public string Descripcion { get; set; }

        [FirestoreProperty]
        public bool Completado { get; set; }
    }
}
