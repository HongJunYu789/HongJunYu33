using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
 public   class trainingModel
    {
        public int tra_id { get; set; }
        public string major_kind_id { get; set; }
        public string major_kind_name { get; set; }
        public string human_id { get; set; }
        public string human_name { get; set; }
        public string training_item { get; set; }
        public DateTime MyProptraining_timeerty { get; set; }
        public string register { get; set; }
        public string checker { get; set; }
        public DateTime regist_time { get; set; }
        public DateTime check_time { get; set; }
        public int checkstatus { get; set; }
        public string remark { get; set; }
    }
}
