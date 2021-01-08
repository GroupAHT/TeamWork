using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ThuenhatroClient.Models
{
    public class CreateViewMode
    {
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
        public float Acreage { get; set; }

        public List<IFormFile> Photos { get; set; }

        public DateTime CreateAT { get; set; }
    }
}
