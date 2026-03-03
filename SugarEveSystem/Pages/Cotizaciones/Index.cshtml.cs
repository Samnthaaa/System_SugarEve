using Microsoft.AspNetCore.Mvc.RazorPages;
using Google.Cloud.Firestore;
using SugarEveSystem.Models;
using SugarEveSystem.Services;

namespace SugarEveSystem.Pages.Cotizaciones
{
    public class IndexModel : PageModel
    {
        private readonly FirebaseConfig _firebaseConfig;
        
        public List<Cotizacion> Cotizaciones { get; set; }

        public IndexModel(FirebaseConfig firebaseConfig)
        {
            _firebaseConfig = firebaseConfig;
        }

        public async Task OnGetAsync()
        {
            var db = _firebaseConfig.GetFirestoreDb();
            if (db != null)
            {
                Cotizaciones = new List<Cotizacion>();
                Query query = db.Collection("cotizaciones").OrderByDescending("FechaEvento");
                QuerySnapshot snapshot = await query.GetSnapshotAsync();

                foreach (DocumentSnapshot document in snapshot.Documents)
                {
                    if (document.Exists)
                    {
                        var item = document.ConvertTo<Cotizacion>();
                        item.Id = document.Id;
                        Cotizaciones.Add(item);
                    }
                }
            }
        }
    }
}
