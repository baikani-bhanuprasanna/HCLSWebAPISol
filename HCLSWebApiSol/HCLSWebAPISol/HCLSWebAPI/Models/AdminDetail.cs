using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HCLSWebAPI.Models
{
    [Table("AdminDetail")]
    public class AdminDetail
    {

        [Key]
        public int AdminId { get; set; }

        [Required(ErrorMessage ="Please Enter Your Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please Enter Your Password")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please Select Your Gender")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Please Enter Your Email")]
        public string Email { get; set; }

        public bool Active { get; set; }

        [Required(ErrorMessage = "Please Enter Your MobileNumber")]
        public string MobileNumber { get; set; }

        [Required(ErrorMessage = "Please Enter Your Address")]
        public string Address { get; set; }

        [ForeignKey("Admin")]
        [Required(ErrorMessage = "Please Enter Your AdminTypeId")]
        public int AdminTypeId { get; set; }

        public Admin? Admin { get; set; }
    }
}
