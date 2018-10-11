using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Music.Models
{
    public class Customer
    {
        public Guid CustomerId { get; set; }
        public string CustomerName { get; set; }
        public MembershipType MembershipType { get; set; }
        public int MembershipTypeId { get; set; }
    }
}