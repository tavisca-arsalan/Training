using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tavisca.Model.EmployeeManagementService;

namespace Tavisca.Model.Translators
{
    public static class CredentialTranslator
    {
        public static Credentials ToDataContract(ClientCredentials clientCredentials)
        {
            Credentials credentials = new Credentials()
            {
                 EmailId= clientCredentials.EmailId,
                 Password=clientCredentials.Password
            };
            return credentials;
        }

        public static ClientCredentials ToClientModel(Credentials credentials)
        {
            ClientCredentials clientCredentials = new ClientCredentials()
            {
                EmailId = credentials.EmailId,
                Password = credentials.Password
            };
            return clientCredentials;
        }
    }
}
