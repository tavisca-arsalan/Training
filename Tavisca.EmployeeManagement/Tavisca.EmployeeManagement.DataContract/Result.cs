using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Tavisca.EmployeeManagement.DataContract
{
    [DataContract]
    public class Result
    {
        [DataMember]
        public Status Status;
        public Result()
        {
            Status = new Status();
            Status.StatusCode = "200";
            Status.Message = "OK";
        }
    }

}
