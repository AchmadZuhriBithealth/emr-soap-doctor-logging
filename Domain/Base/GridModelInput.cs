using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Base
{
    public class GridModelInput
    {
        public string SortField { get; set; }
        public int SortOrder { get; set; }
        public int First { get; set; }
        public int Rows { get; set; }
    }
}
