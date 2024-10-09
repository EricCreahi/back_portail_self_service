using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Models
{
    [Table(name: "TBL_AUDIT", Schema = "dbo")]
    public class Audit
    {
        [Key]
        [Column(Order = 0)]
        public int AuditId { get; set; }

        [Column(Order = 1)]
        public DateTime DateTrace { get; set; }

        [Column(Order = 2)]
        public string TypeAction { get; set; }

        [Column(Order = 3), StringLength(255)]
        public string DetailAction { get; set; }

        [Column(Order = 4), StringLength(50)]
        public string IpSource { get; set; }



        [Column(Order = 5), StringLength(20)]
        public string UserId { get; set; }
        [ForeignKey("UserId")]
        public Utilisateur utilisateur { get; set; }
    }
}
