using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TheSimpleCalendar2018.Models
{
    public class ProflieResponse
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Home { get; set; }
        public string Work  { get; set; }
        public string School { get; set; }
        public string Location { get; set; }
        public bool? WillAttend { get; set; }
    }
}