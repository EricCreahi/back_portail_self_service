using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Models
{

    [Table(name: "TBL_BODY_CARD", Schema = "dbo")]
    public class Body_card
    {
        [Key]
        [Column(Order = 0)]
        public int Id_Body_Card { get; set; }

        [Column(Order = 1), StringLength(225)]
        public string Url_Image { get; set; }

        [Column(Order = 2), StringLength(50)]
        public string Titre { get; set; }

        [Column(Order = 3), StringLength(200)]
        public string Detail { get; set; }

        [Column(Order = 4), StringLength(150)]
        public string Lien { get; set; }

        [Column(Order = 5)]
        public int Numero { get; set; }

    }
}
