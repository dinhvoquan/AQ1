using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AQ1.Model.Models
{
    [Table("Supports")]
    public class Support
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [Required]
        [MaxLength(256)]
        public string Name { set; get; }

        [MaxLength(256)]
        public string Department { set; get; }

        [MaxLength(50)]
        public string Phone { set; get; }

        [MaxLength(50)]
        public string UltraViewer { set; get; }

        [MaxLength(50)]
        public string Email { set; get; }

        public bool Status { set; get; }

        public int? DisplayOrder { set; get; }
    }
}
