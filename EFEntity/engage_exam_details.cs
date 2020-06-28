using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFEntity
{
  public  class engage_exam_details
 //   
    {
 //	exd_id smallint identity not null,
 //exam_number varchar(30) null,
 //first_kind_id char (2) null,
 //first_kind_name varchar(60) null,
 //second_kind_id char (2) null,
 //second_kind_name varchar(60) null,
 //question_amount smallint null)  
    public int exd_id { get; set; }
        public string exam_number { get; set; }
        public string first_kind_id { get; set; }
        public string first_kind_name { get; set; }
        public string second_kind_id { get; set; }
        public string second_kind_name { get; set; }
        public int question_amount { get; set; }
    }
}
