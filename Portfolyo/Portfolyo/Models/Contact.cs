using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolyo.Models
{
    public class Contact
    {
        public int ContactID { get; set; }
        public string NameSurname { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public bool ReadReceipt { get; set; } = false;
        public bool Status { get; set; } = true;
    }
}
