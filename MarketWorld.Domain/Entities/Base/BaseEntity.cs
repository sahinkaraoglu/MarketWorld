using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketWorld.Domain.Entities.Base
{
    public class BaseEntity
    {
        [Column(Order = 0), Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        
        public bool IsDeleted { get; set; } = false;
        
        public long? CreatedById { get; set; }
        
        public DateTime? CreatedDate { get; set; }
        
        public long? UpdatedById { get; set; }
        
        public DateTime? UpdatedDate { get; set; }
    }
}
