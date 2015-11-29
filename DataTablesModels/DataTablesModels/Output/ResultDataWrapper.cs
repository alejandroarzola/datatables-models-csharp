using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTables.Models.Output
{
    public class ResultDataWrapper
    {
        public int draw { get; set; }
        public int recordsTotal { get; set; }
        public int recordsFiltered { get; set; }
        public List<object> data { get; set; }
        public string error { get; set; }
    }
}
