using Microsoft.AspNetCore.Mvc.RazorPages;
using Google.Cloud.Firestore;
using SugarEveSystem.Models;
using SugarEveSystem.Services;

namespace SugarEveSystem.Pages.Checklists
{
    public class IndexModel : PageModel
    {
        private readonly FirebaseConfig _firebaseConfig;
        
        public List<ServicioChecklist> Servicios { get; set; }

        public IndexModel(FirebaseConfig firebaseConfig)
        {
            _firebaseConfig = firebaseConfig;
        }

        public async Task OnGetAsync()
        {
            var db = _firebaseConfig.GetFirestoreDb();
            if (db != null)
            {
                Servicios = new List<ServicioChecklist>();
                Query query = db.Collection("checklists");
                QuerySnapshot snapshot = await query.GetSnapshotAsync();

                foreach (DocumentSnapshot document in snapshot.Documents)
                {
                    if (document.Exists)
                    {
                        var item = document.ConvertTo<ServicioChecklist>();
                        item.Id = document.Id;
                        Servicios.Add(item);
                    }
                }
            }
        }
    }
}
