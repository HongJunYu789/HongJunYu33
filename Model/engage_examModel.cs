using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
  public  class engage_examModel
    {
        public int exa_id { get; set; }
        public string exam_number { get; set; }
        public string major_kind_id { get; set; }
        public string major_kind_name { get; set; }
        public string major_id { get; set; }
        public string major_name { get; set; }
        public string register { get; set; }
        public DateTime regist_time { get; set; }
        public int limite_time { get; set; }
    }
}
