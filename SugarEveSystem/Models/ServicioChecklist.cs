using Google.Cloud.Firestore;

namespace SugarEveSystem.Models
{
    [FirestoreData]
    public class ServicioChecklist
    {
        public string Id { get; set; }

        [FirestoreProperty]
        public string TituloServicio { get; set; } // Ej. "Barra de Snacks"

        [FirestoreProperty]
        public string TipoServicio { get; set; } // "Backdrops", "Miniferia", "BarraSnacks", etc.

        [FirestoreProperty]
        public string EventoAsociado { get; set; } // Nombre del evento o cliente

        [FirestoreProperty]
        public string Responsable { get; set; }

        [FirestoreProperty]
        public string Estado { get; set; } // "Preparación", "En tránsito", "Montaje", "Finalizado"

        [FirestoreProperty]
        public bool ConfirmacionFinal { get; set; }

        [FirestoreProperty]
        public List<CheckItemSeccion> Secciones { get; set; }

        // Compatibilidad legacy
        [FirestoreProperty]
        public List<CheckItem> Materiales { get; set; }
    }

    [FirestoreData]
    public class CheckItemSeccion
    {
        [FirestoreProperty]
        public string NombreSeccion { get; set; } // Ej: "Materiales", "Logística", "Montaje"

        [FirestoreProperty]
        public List<CheckItem> Items { get; set; }
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
