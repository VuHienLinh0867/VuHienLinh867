using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace VUHIENLINH867.Models
{
    [Table("VHL0867")]
    public class VHL0867 
    {
        [Key]
        [StringLength(20)]
        public string VHLId { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage ="VHLName is required")]
        public string VHLName { get; set; }

        [Required(ErrorMessage ="VHLGender is required")]
        public Boolean VHLGender { get; set; }
    }
}