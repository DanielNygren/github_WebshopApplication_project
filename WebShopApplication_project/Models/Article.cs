using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebShopApplication_project.Models
{
    public class Article
    {
        public int ID { get; set; }
        [Required]
        [MaxLength(250)]
        public string ArticleNumber { get; set; }
        [Required]
        [MaxLength(250)]
        public string Name { get; set; }
        [Required]
        [MaxLength(250)]
        public string Price { get; set; }
        [Required]
        [MaxLength(2000)]
        public string Description { get; set; }
        [MaxLength(50)]
        public string Hight { get; set; }
        [MaxLength(50)]
        public string Whith { get; set; }
        [MaxLength(50)]
        public string Depth { get; set; }
        [MaxLength(50)]
        public string NetWweight { get; set; }
        [MaxLength(50)]
        public string GrossWeight { get; set; }
        public List<Media> Media { get; set; }
        [Required]
        public DateTime DateTimeItemCreated { get; set; }
        public DateTime DateTimeItemUpdated { get; set; }
        public List<Category> Categorys { get; set; }
    }
}
