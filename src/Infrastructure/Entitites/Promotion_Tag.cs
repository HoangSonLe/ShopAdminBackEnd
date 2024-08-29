using Infrastructure.DBContexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Entitites
{
    public class Promotion_Tag
    {
        public int Tag { get; set; }
        public Tag Tag { get; set; }
        public int PromotionId { get; set; }
        public Promotion Promotion { get; set; }
    }
}
