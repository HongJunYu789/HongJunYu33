using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFEntity
{
   public class engage_exam
    {
        //	exa_id smallint identity not null,
        //exam_number varchar(30) null,
        //major_kind_id char (2) null,
        //major_kind_name varchar(60) null,
        //major_id char (2) null,
        //major_name varchar(60) null,
        //register varchar(60) null,
        //regist_time datetime null,
        //limite_time smallint null)  
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
