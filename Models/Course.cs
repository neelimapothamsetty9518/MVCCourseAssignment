using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace assignmentjan31WebApplication1.Models
{
    public class Course
    {
        public int cid { get; set; }
        public string Cname { get; set; }
        public decimal CFee { get; set; }
        public string Technology { get; set; }
        public DateTime CstartDate { get; set; }
        public DateTime CEndDate { get; set; }
    }
}