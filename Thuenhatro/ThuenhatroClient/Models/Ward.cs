using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace ThuenhatroClient.Models
{
    public class Ward
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        public string _name { get; set; }

        public string _prefix { get; set; }
        public int _province_id { get; set; }
        public int _district_id { get; set; }
    }
}
