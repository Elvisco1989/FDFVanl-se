using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FDFLodsedler.Model
{
    public class Betaling
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Betal_Id { get; set; }
        [Required]
        public int Amount { get; set; }
        [Required]
        public string PaymentMethod { get; set; }
        [Column("Børn_Id")]
        public int? BørneId { get; set; }
    }
}

