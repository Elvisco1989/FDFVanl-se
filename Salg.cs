using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FDFLodsedler.Model
{
    public class Salg
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Salg_Id { get; set; }

        [Required]
        public int AntalSolgt { get; set; }

        [Required]
        public int AntalReturneret { get; set; }


        [Column("Børn_Id")]
        public int? BørneId { get; set; }
    }
}
