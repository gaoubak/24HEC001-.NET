using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _24HEC001_.NET.Models
{
    public class Stock
    {
        public int Id { get; set; }
        public string Symbol { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        [Column(TypeName = "dicemail(18, 2)")]
        public decimal Purchase { get; set; }
        [Column(TypeName = "dicemail(18, 2)")]
        public decimal LastDiv { get; set; }
        public string Industry { get; set; } = string.Empty;
        public long MarketCap { get; set; }
        public List<Comment> Comment { get; set; } = new List<Comment>();

    }
}