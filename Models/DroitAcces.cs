using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Models
{
    [Table(name: "TBL_DROITACCES", Schema = "dbo")]
    public class DroitAcces
    {
        [Key]
        [Column(Order = 1)]
        public int DroitAccesId { get; set; }

        [Column(Order = 2), StringLength(200)]
        public string Libelle { get; set; }

        [Column(Order = 3)]
        public int Level { get; set; }


        public List<Utilisateur> Utilisateurs { get; set; }
    }
}
