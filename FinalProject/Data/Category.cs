using System.ComponentModel.DataAnnotations;

namespace FinalProject.Data
{
    public class Category
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Please enter the name...")]
        public string Name { get; set; }= string.Empty;
    }
}
