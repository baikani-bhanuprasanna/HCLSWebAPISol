using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace HCLSWebAPI.Models
{
    [Table("Admin")]
    public class Admin
    {

        [Key]
        public int AdminTypeId { get; set; }

        public string AdminTypeName { get; set; }


        public ICollection<AdminDetail>? AdminDetail { get; set; }
    }
}
