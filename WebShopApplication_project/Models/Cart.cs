using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebShopApplication_project.Data;

namespace WebShopApplication_project.Models
{
    public class Cart
    {
        public int ID { get; set; }
        public string UserID { get; set; }
        public ApplicationUser User { get; set; }
        public List<Article> Article { get; set; }
    }
}
