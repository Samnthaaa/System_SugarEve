using FirebaseAdmin;
using Google.Apis.Auth.OAuth2;
using Google.Cloud.Firestore;

namespace SugarEveSystem.Services
{
    public class FirebaseConfig
    {
        private FirestoreDb _firestoreDb;

        public FirebaseConfig(IConfiguration configuration)
        {
            var credentialPath = configuration["FirebaseCredentialsPath"];
            
            // Allow bypassing in development if file doesn't exist yet to avoid crash on startup
            if (File.Exists(credentialPath))
            {
                Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", credentialPath);
                
                if (FirebaseApp.DefaultInstance == null)
                {
                    FirebaseApp.Create(new AppOptions
                    {
                        Credential = GoogleCredential.FromFile(credentialPath)
                    });
                }

                var projectId = configuration["FirebaseProjectId"];
                if (!string.IsNullOrEmpty(projectId))
                {
                    _firestoreDb = FirestoreDb.Create(projectId);
                }
            }
        }

        public FirestoreDb GetFirestoreDb()
        {
            return _firestoreDb;
        }
    }
}
