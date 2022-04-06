using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebShopApplication_project.Models
{
    public class Order
    {
        public int ID { get; set; }
        public DateTime OrderDateTime { get; set; }
        [Required]
        public Customer Customer { get; set; }
        public List<Article> Article { get; set; }

    }

}
