using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
   public class engage_answerModel
    {
        public int ans_id { get; set; }
        public string answer_number { get; set; }
        public string exam_number { get; set; }
        public int resume_id { get; set; }
        public int interview_id { get; set; }
        public string human_name { get; set; }
        public string human_idcard { get; set; }
        public string major_kind_id { get; set; }
        public string major_kind_name { get; set; }
        public DateTime test_time { get; set; }
        public string use_time { get; set; }
        public double total_point { get; set; }
    }
}
