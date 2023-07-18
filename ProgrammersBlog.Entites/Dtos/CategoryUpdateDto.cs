using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersBlog.Entites.Dtos
{
    public class CategoryUpdateDto
    {
        [Required]
        public int Id { get; set; }
        [DisplayName("Category Name")]
        [Required(ErrorMessage = "{0} is not Null")]
        [MaxLength(70, ErrorMessage = "{0}is not bigger than{1}")]
        [MinLength(3, ErrorMessage = "{0}is not smaller then {1}")]
        public string Name { get; set; }
        [DisplayName("Category Description")]
        [MaxLength(500, ErrorMessage = "{0}is not bigger than{1}")]
        [MinLength(3, ErrorMessage = "{0}is not smaller then {1}")]
        public string Description { get; set; }
        [DisplayName("Category Note")]
        [MaxLength(500, ErrorMessage = "{0}is not bigger than{1}")]
        [MinLength(3, ErrorMessage = "{0}is not smaller then {1}")]
        public string Note { get; set; }
        [DisplayName("Is Active?")]
        [Required(ErrorMessage = "{0} is not Null")]
        public bool IsActive { get; set; }
        [DisplayName("Is Deleted?")]
        [Required(ErrorMessage = "{0} is not Null")]
        public bool IsDeleted { get; set; }
    }
}
