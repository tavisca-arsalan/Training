using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tavisca.Model.EmployeeManagementService;

namespace Tavisca.Model.Translators
{
    public static class RemarkTranslator
    {
        public static Remark ToDataContract(ClientRemark clientRemark)
        {
            Remark remark = new Remark()
            {
                Text = clientRemark.Text,
                CreateTimeStamp = clientRemark.CreateTimeStamp
            };
            return remark;
        }

        public static ClientRemark ToClientModel(Remark remark)
        {
            ClientRemark clientRemark = new ClientRemark()
            {
                Text = remark.Text,
                CreateTimeStamp = remark.CreateTimeStamp
            };
            return clientRemark;
        }
    }
}
