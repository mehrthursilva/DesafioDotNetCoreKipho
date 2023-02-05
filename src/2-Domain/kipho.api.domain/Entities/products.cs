using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kipho.api.domain.Entities
{
    public class Products : BaseEntity
    {
        public string? name { get; set; }
        //[Column(TypeName = "decimal(18,2)")]
        public double? price { get; set; }
        public string? brand { get; set; }
    }
}
