using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Asp.Net_Framework.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public string firstName { get; set; }

        public string lastName { get; set; }

        public Contact()
        {
            Id = -1;
            firstName = string.Empty;
            lastName = string.Empty;
        }
    }
}