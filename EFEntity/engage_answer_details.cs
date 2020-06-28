using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFEntity
{
   public class engage_answer_details
    {
 //       and_id smallint identity not null,
 //   answer_number varchar(30) null,
	//subject_id smallint null,
 //   answer varchar(10) null)  

        public int and_id { get; set; }
        public string answer_number { get; set; }
        public int subject_id { get; set; }
        public string answer { get; set; }
    }
}
