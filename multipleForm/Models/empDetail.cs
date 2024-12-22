using System.ComponentModel.DataAnnotations;

namespace multipleForm.Models
{
    public class empDetail
    {
        [Key]
        public int MyProperty { get; set; }
        public string? name { get; set; }
        public int age { get; set; }
    }
}