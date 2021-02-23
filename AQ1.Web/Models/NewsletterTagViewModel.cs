using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AQ1.Web.Models
{
    public class NewsletterTagViewModel
    {
        public int NewsletterID { set; get; }

        public string TagID { set; get; }

        public virtual NewsletterViewModel Newsletter { set; get; }

        public virtual TagViewModel Tag { set; get; }
    }
}