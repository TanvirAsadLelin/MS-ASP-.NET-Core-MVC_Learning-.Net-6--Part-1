
using System.ComponentModel.DataAnnotations;
namespace LearnASP.NETCoreMVC_DotNet_6_WebApp.Models
{
    public class Category
    {   
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int DisplayOrder { get; set; }
        public DateTime CreateDateTime { get; set; } = DateTime.Now;
    }
}
