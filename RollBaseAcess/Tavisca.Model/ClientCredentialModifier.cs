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
    public class ClientCredentialModifier
    {
        public string EmailId { get; set; }

        public string OldPassword { get; set; }

        public string NewPassword { get; set; }
 
        public int ChangePassword()
        {
            CredentialModifier credentialModifier = CredentialModifierTranslator.ToDataContract(this);
            string EmployeeManagementServiceUrl = ConfigurationManager.AppSettings["EmployeeManagementServiceUrl"];
            var client = new HttpClient();
            string result = client.UploadData< CredentialModifier, string>(EmployeeManagementServiceUrl + "change_password", credentialModifier);
            return Int16.Parse(result);
        
        }
    }
}
