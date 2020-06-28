using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFEntity
{
   public class engage_major_release
    {
        //	mre_id smallint identity not null,
        //first_kind_id char (2) null,
        //first_kind_name varchar(60) null,
        //second_kind_id char (2) null,
        //second_kind_name varchar(60) null,
        //third_kind_id char (2) null,
        //third_kind_name varchar(60) null,
        //major_kind_id char (2) null,
        //major_kind_name varchar(60) null,
        //major_id char (2) null,
        //major_name varchar(60) null,
        //human_amount smallint null,
        //engage_type varchar(60) null,
        //deadline datetime null,
        //register varchar(60) null,
        //changer varchar(60) null,
        //regist_time datetime null,
        //change_time datetime null,
        //major_describe text null,
        //engage_required text null)  
        public int mre_id { get; set; }
        public string first_kind_id { get; set; }
        public string first_kind_name { get; set; }
        public string second_kind_id { get; set; }
        public string second_kind_name { get; set; }
        public string third_kind_id { get; set; }
        public string third_kind_name { get; set; }
        public string major_kind_id { get; set; }
        public string major_kind_name { get; set; }
        public string major_id { get; set; }
        public string major_name { get; set; }
        public int human_amount { get; set; }
        public string engage_type { get; set; }
        public DateTime deadline { get; set; }
        public string register { get; set; }
        public string changer { get; set; }
        public DateTime regist_time { get; set; }
        public DateTime change_time { get; set; }
        public string major_describe { get; set; }
        public string engage_required { get; set; }

    }
}
