using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tavisca.Model.EmployeeManagementService;

namespace Tavisca.Model.Translators
{
    public static class CredentialModifierTranslator
    {
        public static CredentialModifier ToDataContract(ClientCredentialModifier clientCredentialModifier)
        {
            CredentialModifier credentialModifier = new CredentialModifier()
            {
                EmailId=clientCredentialModifier.EmailId,
                OldPassword=clientCredentialModifier.OldPassword,
                NewPassword=clientCredentialModifier.NewPassword                
            };
            return credentialModifier;
        }

        public static ClientCredentialModifier ToClientModel(CredentialModifier credentialModifier)
        {
            ClientCredentialModifier clientCredentialModifier = new ClientCredentialModifier()
            {
                EmailId = credentialModifier.EmailId,
                OldPassword = credentialModifier.OldPassword,
                NewPassword=credentialModifier.NewPassword
            };
            return clientCredentialModifier;
        }
    }
}
