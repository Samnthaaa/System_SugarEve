using Microsoft.AspNetCore.Mvc.RazorPages;
using Google.Cloud.Firestore;
using SugarEveSystem.Models;
using SugarEveSystem.Services;

namespace SugarEveSystem.Pages.Inventario
{
    public class IndexModel : PageModel
    {
        private readonly FirebaseConfig _firebaseConfig;
        
        public List<InventarioItem> Inventario { get; set; }

        public IndexModel(FirebaseConfig firebaseConfig)
        {
            _firebaseConfig = firebaseConfig;
        }

        public async Task OnGetAsync()
        {
            var db = _firebaseConfig.GetFirestoreDb();
            if (db != null)
            {
                Inventario = new List<InventarioItem>();
                Query query = db.Collection("inventario");
                QuerySnapshot snapshot = await query.GetSnapshotAsync();

                foreach (DocumentSnapshot document in snapshot.Documents)
                {
                    if (document.Exists)
                    {
                        var item = document.ConvertTo<InventarioItem>();
                        item.Id = document.Id;
                        Inventario.Add(item);
                    }
                }
            }
        }
    }
}
