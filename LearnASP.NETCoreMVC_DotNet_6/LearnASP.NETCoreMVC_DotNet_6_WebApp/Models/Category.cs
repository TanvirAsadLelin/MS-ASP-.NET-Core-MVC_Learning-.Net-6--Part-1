
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace LearnASP.NETCoreMVC_DotNet_6_WebApp.Models
{
    public class Category
    {   
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [DisplayName("Display Order")]
        [Range(1,100,ErrorMessage ="Display order range 1 to 100 only!")]
        public int DisplayOrder { get; set; }
        public DateTime CreateDateTime { get; set; } = DateTime.Now;
    }
}
