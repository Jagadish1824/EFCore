using System.ComponentModel.DataAnnotations;

namespace CodeFirstPractice.Models
{
    public class Students
    {
        [Key]
        public int StuId { get; set; }
        public string StuName { get; set; }
        public string Marks { get; set; }
    }
}
