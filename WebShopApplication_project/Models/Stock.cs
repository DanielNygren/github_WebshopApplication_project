using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebShopApplication_project.Models
{
    public class Stock
    {
        public int ID { get; set; }
        public Article Article { get; set; }
        [Required]
        [MaxLength(250)]
        public int Saldo { get; set; }
        public DateTime DateTimeInverse { get; set; }

        public StockLocation StockLocation { get; set; }
    }
}
