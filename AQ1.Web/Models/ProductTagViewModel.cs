using AQ1.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AQ1.Web.Models
{
    public class ProductTagViewModel
    {      
        public int ProductID { set; get; }

        public string TagID { set; get; }

        public virtual Product Product { set; get; }

        public virtual Tag Tag { set; get; }
    }
}
