using System.ComponentModel.DataAnnotations;

namespace FDFLodsedler.Model
{
    public class RegisterUser
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }


        [Required]
        [DataType(DataType.Password)]
        [Compare(nameof(Password), ErrorMessage = "Password and confirmation did not match")]


        public string ConfrimPassword
        {
            get; set;
        }
    }
}
