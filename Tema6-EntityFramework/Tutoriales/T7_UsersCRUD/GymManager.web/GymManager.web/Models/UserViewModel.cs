using System.ComponentModel.DataAnnotations;

namespace GymManager.web.Models
{
    public class UserViewModel
    {
        

        [EmailAddress]
        [Required]
        [StringLength(256)]
        public string UserName { get; set; }
        [Required]
        [StringLength(32)]
        public string PhoneNumber { get; set; }
        [Required]
        [StringLength(100, MinimumLength =5)]
        public string Password { get; set; }


        public string Id { get; set; }
    }
}
