using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
  public  class Page<T>
    {
        public List<T> dt { get; set; }
        public int Pages { get; set; }
        public int Rows { get; set; }
    }
}
