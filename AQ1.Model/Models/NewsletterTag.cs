using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AQ1.Model.Models
{
    [Table("NewsletterTags")]
    public class NewsletterTag
    {
        [Key]
        [Column(Order =1)]
        public int NewsletterID { set; get; }

        [Key]
        [Column(TypeName ="varchar", Order = 2)]
        [MaxLength(50)]
        public string TagID { set; get; }

        [ForeignKey("NewsletterID")]
        public virtual Newsletter Newsletter { set; get; }

        [ForeignKey("TagID")]
        public virtual Tag Tag { set; get; }
    }
}
