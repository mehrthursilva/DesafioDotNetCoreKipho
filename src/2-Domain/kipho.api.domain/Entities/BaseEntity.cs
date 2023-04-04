using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kipho.api.domain.Entities
{
    public class BaseEntity
    {
        [Key]
        public Guid? id { get; set; }
        public int active { get; set; }
        public DateTime? createdAt { get; set; } = DateTime.Now;
        public DateTime? updatedAt { get; set; }
        public string? barcodeNumber { get; set; }
    }
}
