using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FDFLodsedler.Model
{
    public class Lodseldler
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Lod_Id { get; set; }

        [Required]
        public int AntalUdleveret { get; set; }


        [Column("Børn_Id")]
        public int? BørneId { get; set; }

        //public virtual Børn Børn { get; set; }

        //public Børn Børn { get; set; }


    }
}
