using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebShopApplication_project.Models
{
    public class Media
    {
        public int ID { get; set; }
        public string Titel { get; set; }
        [Required]
        public string MediaPath { get; set; }

    }
}
