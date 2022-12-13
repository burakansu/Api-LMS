using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Model
{
    public class TBL_Users
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int User_ID { get; set; }
        [StringLength(50)]
        public string Mail { get; set; }
        [StringLength(50)]
        public string Password { get; set; }
        public int Type { get; set; }
    }
}
