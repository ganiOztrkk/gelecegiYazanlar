using System.ComponentModel.DataAnnotations;

namespace CampingApp.Mvc.Models
{
    public class UserLoginViewModel
    {
        [Required(ErrorMessage = "Kullanıcı Adı Boş Geçilemez")]
        public string UserName { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
