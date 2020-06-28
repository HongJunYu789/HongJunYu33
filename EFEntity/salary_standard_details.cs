using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFEntity
{
   public class salary_standard_details
    {
	//	sdt_id smallint identity not null,
	//standard_id varchar(30) null,
	//standard_name varchar(60) null,
	//item_id smallint null,
	//item_name varchar(60) null,
	//salary money null)  

		public int sdt_id { get; set; }
        public string standard_id { get; set; }
        public string standard_name { get; set; }
        public int item_id { get; set; }
        public string item_name { get; set; }
        public double salary { get; set; }
    }
}
