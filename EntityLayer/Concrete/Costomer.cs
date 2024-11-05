using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Costomer
    {
        public int CostomerID { get; set; }
        public string? CostomerNAme { get; set; }
        public string? CostomerCity { get; set; }
        public int JobID { get; set; }
        public Job? Job { get; set; }
    }
}
