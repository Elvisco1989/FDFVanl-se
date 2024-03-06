using FDFLodsedler.Interface;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace FDFLodsedler.Model
{
    public class Børn
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Børn_Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Navn { get; set; }
        
        public int? GruppeId { get; set; }


        public virtual BørneGruppe BørneGruppe { get; set; }
    }


}

