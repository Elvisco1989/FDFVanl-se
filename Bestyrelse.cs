using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FDFLodsedler.Model
{
    public class Bestyrelse
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Bestyrelse_Id { get; set; }

        [Required]
        public string Navn { get; set; }

    }
}
