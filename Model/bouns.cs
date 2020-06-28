using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
  public  class bouns
    {
        public int bon_id { get; set; }
        public string major_kind_id { get; set; }
        public string major_kind_name { get; set; }
        public string major_id { get; set; }
        public string major_name { get; set; }
        public string human_id { get; set; }
        public string human_name { get; set; }
        public string bonus_item { get; set; }
        public double bonus_worth { get; set; }
        public string bonus_degree { get; set; }
        public string register { get; set; }
        public string checker { get; set; }
        public DateTime regist_time { get; set; }
        public DateTime check_time { get; set; }
        public int check_status { get; set; }
    }
}
