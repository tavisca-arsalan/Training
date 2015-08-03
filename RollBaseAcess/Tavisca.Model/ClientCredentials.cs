using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tavisca.Model.EmployeeManagementService;
using Tavisca.Model.Translators;

namespace Tavisca.Model
{
    public class ClientCredentials
    {
        public string EmailId { get; set; }

        public string Password { get; set; }

        public ClientEmployee Authenticate()
        {
            try
            {
                Credentials credentials = CredentialTranslator.ToDataContract(this);
                string EmployeeManagementServiceUrl = ConfigurationManager.AppSettings["EmployeeManagementServiceUrl"];
                var client = new HttpClient();
                var response = client.UploadData<Credentials, Employee>(EmployeeManagementServiceUrl + "login", credentials);
                return EmployeeTranslator.ToClientModel(response);
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
