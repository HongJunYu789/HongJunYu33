using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFEntity
{
 public   class config_question_second_kind
    {
        //	qsk_id smallint identity not null,
        //first_kind_id char (2) ,
        //first_kind_name varchar(60) ,
        //second_kind_id char (2) ,
        //second_kind_name varchar(60) )  

        public int qsk_id { get; set; }
        public string first_kind_id { get; set; }
        public string first_kind_name { get; set; }
        public string second_kind_id { get; set; }
        public string second_kind_name { get; set; }
    }
}
