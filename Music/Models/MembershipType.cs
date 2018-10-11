using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Music.Models
{
    public class MembershipType
    {
        public int Id { get; set; }
        public  string Name { get; set; }
        public string Discount { get; set; }
        public string Period { get; set; }
    }
}