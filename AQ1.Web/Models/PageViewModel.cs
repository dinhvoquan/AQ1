using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AQ1.Web.Models
{
    public class PageViewModel
    {
        public int ID { set; get; }
      
        public string Name { set; get; }

        public string Alias { set; get; }

        public string Detail { set; get; }

        public bool Status { set; get; }
    }
}