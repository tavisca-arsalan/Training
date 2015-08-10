using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tavisca.Model
{
    public class ClientRemark
    {
        [Required]
        public string Text { get; set; }

        public DateTime CreateTimeStamp { get; set; }
    }
}
