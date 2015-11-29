using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTables.Models.Input
{
    public class InputParameters
    {
        public int draw { get; set; }
        public int start { get; set; }
        public int length { get; set; }
        public Search search { get; set; }
        public List<Order> order { get; set; }
        public List<Column> columns{ get; set; }
    }
}
