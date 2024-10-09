using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Models
{
    [Table(name: "TBL_EMPLOYE", Schema = "dbo")]
    public class Employe
    {
        [Key]
        [Column(Order = 0), StringLength(20)]
        public string Matricule { get; set; }

        [Column(Order = 1), StringLength(150)]
        public string NomPrenoms { get; set; }

        [Column(Order = 2), StringLength(255)]
        public string Direction { get; set; }

        [Column(Order = 3), StringLength(150)]
        public string Fonction { get; set; }

        [Column(Order = 4), StringLength(100)]
        public string Categorie { get; set; }

        [Column(Order = 5), StringLength(100)]
        public string Statut { get; set; }

   



    }


}
