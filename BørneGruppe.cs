using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FDFLodsedler.Model
{
    public class BørneGruppe
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //[Column("Gruppe_Id")]
        public int Gruppe_Id { get; set; }

        //public int? GruppeId { get; set; }
        [Required]
        [StringLength(50)]
        public string Navn { get; set; }

        //[Required]
        //[ForeignKey("Leder_Id")]
        //public Leder Leder { get; set; }

        [Column("Leder_Id")]
        public int LederId { get; set; }

        //public virtual Leder Leder { get; set; }
    }
}
