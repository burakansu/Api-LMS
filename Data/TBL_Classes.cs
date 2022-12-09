using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data
{
    public class TBL_Classes
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Class_ID { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
    }
}
