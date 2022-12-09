using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Data
{
    public class TBL_Notes
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Note_ID { get; set; }
        public int Lesson_ID { get; set; }
        public int Student_ID { get; set; }
        public int Note { get; set; }
    }
}
