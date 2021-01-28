using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using ThuenhatroClient.Models;

namespace ThuenhatroClient.Models
{
    public class NewsView
    {
        public Property Property { get; set; }
        public Ward Ward { get; set; }
        public Districks Districks { get; set; }

        public Provider Provider { get; set; }
    }
}
