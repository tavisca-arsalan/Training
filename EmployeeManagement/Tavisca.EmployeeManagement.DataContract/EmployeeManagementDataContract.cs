using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Tavisca.EmployeeManagement.DataContract
{
    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "Tavisca.EmployeeManegent.ServiceLibrary.ContractType".

    [DataContract]
    public class Employee
    {
        [DataMember]
        public string Id
        {
            get;
            set;
        }

        [DataMember]
        public string Title
        {
            get;
            set;
        }

        [DataMember]
        public string FirstName
        {
            get;
            set;
        }

        [DataMember]
        public string LastName
        {
            get;
            set;
        }

        [DataMember]
        public string Email
        {
            get;
            set;
        }

        [DataMember]
        public string EmployeeRemark
        {
            get;
            set;
        }

   }

    [DataContract]
    public class Remark
    {
        [DataMember]
        public DateTime UtcTime
        {
            get;
            set;
        }
        [DataMember]
        public string Text
        {
            get;
            set;
        }

    }
   
}
