using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        public double Price { get; set; }
        [Required]
        [MaxLength(2000)]
        public string Description { get; set; }
        [MaxLength(50)]
        public double Hight { get; set; }
        [MaxLength(50)]
        public double Whith { get; set; }
        [MaxLength(50)]
        public double Depth { get; set; }
        [MaxLength(50)]
        public double NetWweight { get; set; }
        [MaxLength(50)]
        public double GrossWeight { get; set; }
        public List<Media> Media { get; set; }
        [Required]
        public DateTime DateTimeItemCreated { get; set; }
        public DateTime DateTimeItemUpdated { get; set; }
        public int CategoryId { get; set; }
    }
}
