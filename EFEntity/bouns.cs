using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFEntity
{
   public class bouns
    {
        //	bon_id smallint identity not null,
        //major_kind_id char (2) null,
        //major_kind_name varchar(60) null,
        //major_id char (2) null,
        //major_name varchar(60) null,
        //human_id varchar(30) null,
        //human_name varchar(60) null,
        //bonus_item varchar(60) null,
        //bonus_worth money null,
        //bonus_degree varchar(60) null,
        //remark text null,
        //register varchar(60) null,
        //checker varchar(60) null,
        //regist_time datetime null,
        //check_time datetime null,
        //check_status smallint null)  
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
