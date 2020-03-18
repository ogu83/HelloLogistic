using System.Collections.Generic;
using System.Linq;

namespace helloLogistic.Models
{
    public class PartsModel
    {
        public List<Part> Parts { get; set; }

        public int TotalCost { get { return Parts.Sum(x => x.PartCost); } }
    }
}