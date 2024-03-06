using System.ComponentModel.DataAnnotations;

namespace FDFLodsedler.Model
{
    public class CreateRole
    {
        [Required]
        public string RoleName { get; set; }

        public string RoleId { get; set; }

    }
}
