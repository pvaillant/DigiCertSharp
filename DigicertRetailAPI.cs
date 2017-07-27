using Microsoft.Rest;

namespace DigiCertSharp
{
    public partial class DigicertRetailAPI
    {
        public DigicertRetailAPI(string username, string password) : this(new AddAcceptHeaderHandler())
        {
            Credentials = new BasicAuthenticationCredentials { UserName = username, Password = password };
            Credentials.InitializeServiceClient(this);
        }
    }
}