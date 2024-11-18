using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace workshop.Entities
{
    public class Company
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid CompanyId { get; set; }

        public String Name { get; set; }

        public String Location { get; set; }

        public String Category { get; set; }
    }
}
