using System.ComponentModel.DataAnnotations;

namespace multipleForm.Models
{
    public class userDetails
    {
        [Key]
        public int MyProperty { get; set; }
        public string? name { get; set; }
        public string? email { get; set; }
    }
}
