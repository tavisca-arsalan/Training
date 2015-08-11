using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Tavisca.EMS.Security
{
    public class CustomPrincipal:ICustomPrincipal
    {
        public IIdentity Identity { get; private set; }
 
        public CustomPrincipal(string username)
	    {
		    this.Identity = new GenericIdentity(username);
	    }
 
	    public bool IsInRole(string role)
	    {
            return Identity != null && Identity.IsAuthenticated &&
               !string.IsNullOrWhiteSpace(role) && string.Equals(role, Designation, StringComparison.OrdinalIgnoreCase);
	    }
  
        public string Id { get; set; }
       
	    public string FirstName { get; set; }

	    public string LastName { get; set; }

        public string Email  { get; set; }

        public string Designation { get; set; }
    }
}
