using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data
{
    public class TBL_Lessons
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Lesson_ID { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        public int Student_ID { get; set; }
        public int Class_ID { get; set; }
    }
}
