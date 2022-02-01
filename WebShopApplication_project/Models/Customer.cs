using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebShopApplication_project.Data;

namespace WebShopApplication_project.Models
{
    public class Customer
    {
        public int ID { get; set; }
        [Required]
        [MaxLength(250)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(250)]
        public string LastName { get; set; }
        [Required]
        [MaxLength(250)]
        [EmailAddress]
        [Display(Name = "Email")]
        public string EmailAddress { get; set; }
        [Required]
        [MaxLength(250)]
        public string Address1 { get; set; }
        [MaxLength(250)]
        public string Address2 { get; set; }
        [Required]
        [MaxLength(50)]
        public int Postcode { get; set; }
        [Required]
        [MaxLength(50)]
        public string PostArea { get; set; }
    }
}
