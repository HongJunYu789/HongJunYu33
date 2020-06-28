using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFEntity
{
   public class engage_subjects
    {
        //	sub_id smallint identity not null,
        //first_kind_id char (2) null,
        //first_kind_name varchar(60) null,
        //second_kind_id char (2) null,
        //second_kind_name varchar(60) null,
        //register varchar(60) null,
        //regist_time datetime null,
        //derivation varchar(60) null,
        //content text null,
        //key_a text null,
        //key_b text null,
        //key_c text null,
        //key_d text null,
        //key_e text null,
        //correct_key varchar(10) null,
        //changer varchar(60) null,
        //change_time datetime null)  
        public int sub_id { get; set; }
        public string first_kind_id { get; set; }
        public string first_kind_name { get; set; }
        public int second_kind_id { get; set; }
        public string second_kind_name { get; set; }
        public string register { get; set; }
        public DateTime regist_time { get; set; }
        public string derivation { get; set; }
        public string content { get; set; }
        public string key_a { get; set; }
        public string key_b { get; set; }
        public string key_c { get; set; }
        public string key_d { get; set; }
        public string key_e { get; set; }
        public string correct_key { get; set; }
        public string changer { get; set; }
        public DateTime change_time { get; set; }
    }
}
