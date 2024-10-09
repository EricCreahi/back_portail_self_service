using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Models
{
    [Table(name: "TBL_UTILISATEUR", Schema = "dbo")]
    public class Utilisateur
    {
        [Key]
        [Column(Order = 0), StringLength(20)]
        public string UserId { get; set; }

        [Column(Order = 1), StringLength(150)]
        public string Nom { get; set; }

        [Column(Order = 2), StringLength(200)]
        public string Prenoms { get; set; }

        [Column(Order = 3), StringLength(200)]
        public string Mail { get; set; }

        [Column(Order = 4)]
        public bool UserEstActif { get; set; }

        [Column(Order = 5)]
        public DateTime DateCreation { get; set; }

        [Column(Order = 6), StringLength(50)]
        public string UserPassword { get; set; }


        [Column(Order = 7), StringLength(10)]
        public string Usermatricule { get; set; }

        [Column(Order = 8)]
        public int DroitAccesId { get; set; }
        [ForeignKey("DroitAccesId")]
        public DroitAcces DroitAcces { get; set; }

        public List<Audit> Audits { get; set; }

      


    }
}
