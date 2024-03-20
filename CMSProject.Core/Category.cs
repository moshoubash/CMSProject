using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CMSProject.Core
{
    public class Category
    {
        [Required(ErrorMessage = "This field is required")]
        [Display(Name = "Category Id")]
        public int Id { get; set; }
        [Required(ErrorMessage = "This field is required")]
        [Display(Name = "Category Name")]
        [MinLength(2, ErrorMessage = "Min length is 2 characters")]
        [MaxLength(50, ErrorMessage = "Max length is 50 characters")]
        [DataType(DataType.Text)]
        public string Name { get; set; }
    }
}
