using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFEntity
{
  public  class engage_answer
    {
        //	ans_id smallint identity not null,
        //answer_number varchar(30) null,
        //exam_number varchar(30) null,
        //resume_id smallint null,
        //interview_id smallint null,
        //human_name varchar(60) null,
        //human_idcard varchar(30) null,
        //major_kind_id char (2) null,
        //major_kind_name char (10) null,
        //major_id char (10) null,
        //major_name char (10) null,
        //test_time datetime null,
        //use_time varchar(20) null,
        //total_point numeric(5,2) null)  
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
