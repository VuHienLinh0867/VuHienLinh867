using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace VUHIENLINH867.Models
{
    [Table("CompanyVHL867")]
    public class CompanyVHL867
    {
        [Key]
        [StringLength(20)]
        public string CompanyId { get; set; }

        [StringLength(50)]
        public string CompanyName { get; set; }
    }
}