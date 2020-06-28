using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
   public class engage_subjectsModel
    {
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
