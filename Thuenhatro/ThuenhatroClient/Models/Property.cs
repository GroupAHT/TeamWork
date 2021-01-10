using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ThuenhatroClient.Models
{
    public class Property
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PropertyCode { get; set; }

        public int CategoryCode { get; set; }
        public int ProvinceCode { get; set; }
        public int DistrictCode { get; set; }
        public int WardsCode { get; set; }

        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public int Price { get; set; }
        [Required]
        public string Acreage { get; set; }

      
        public DateTime CreateAT { get; set; }
    }
}
