using ProgrammersBlog.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersBlog.Entites.Dtos
{
    public class ArticleAddDto
    {
        [Required(ErrorMessage ="{0} is not null")]
        [MaxLength(100,ErrorMessage ="{0} is not bigger then{1}")]
        [MinLength(5,ErrorMessage ="{0} is not smaller then{1}")]
        public string Title { get; set; }


        [Required(ErrorMessage = "{0} is not null")]
        [MinLength(20, ErrorMessage = "{0} is not smaller then{1}")]
        public string Content { get; set; }


        [Required(ErrorMessage = "{0} is not null")]
        [MaxLength(250, ErrorMessage = "{0} is not bigger then{1}")]
        [MinLength(5, ErrorMessage = "{0} is not smaller then{1}")]
        public string Thumbnail { get; set; }


        [Required(ErrorMessage = "{0} is not null")]
        [DisplayFormat(ApplyFormatInEditMode =true,DataFormatString ="{0:dd/MM/yyyy}")]
        public DateTime Date { get; set; }


        [Required(ErrorMessage = "{0} is not null")]
        [MaxLength(50, ErrorMessage = "{0} is not bigger then{1}")]
        [MinLength(0, ErrorMessage = "{0} is not smaller then{1}")]
        public string SeoAuthor { get; set; }


        [Required(ErrorMessage = "{0} is not null")]
        [MaxLength(70, ErrorMessage = "{0} is not bigger then{1}")]
        [MinLength(5, ErrorMessage = "{0} is not smaller then{1}")]
        public string SeoTags { get; set; }


        [Required(ErrorMessage = "{0} is not null")]
        [MaxLength(150, ErrorMessage = "{0} is not bigger then{1}")]
        [MinLength(0, ErrorMessage = "{0} is not smaller then{1}")]
        public string SeoDescription { get; set; }


        [DisplayName("Category")]
        [Required(ErrorMessage = "{0} is not null")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }


        [Required(ErrorMessage = "{0} is not null")]
        public bool IsActive { get; set; }
    }
}
