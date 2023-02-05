using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kipho.api.domain.Entities
{
    public class products
    {
        [Key]
        public Guid? id { get; set; }
        public DateTime? createdAt { get; set; } = DateTime.Now;
        public string? name { get; set; }
        public double? price { get; set; }
        public string? brand { get; set; }
        public DateTime? updatedAt { get; set; }
    }
}
