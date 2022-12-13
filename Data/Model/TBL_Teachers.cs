using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Model
{
    public class TBL_Teachers
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Teacher_ID { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(50)]
        public string Surname { get; set; }
        public int Class_ID { get; set; }
        public int User_ID { get; set; }
        public int Type { get; set; }
    }
}
