using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebShopApplication_project.Models
{

    public class Category
    {
        public int ID { get; set; }
        [Required]
        [MaxLength(250)]
        [MinLength(2)]
        public string Titel { get; set; }
        [MaxLength(2000)]
        public string Description { get; set; }
        public string ThumbnailImagePath { get; set; }
        public ICollection<Article> Articles { get; set; }

    }
}
