using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFEntity
{
   public class config_major
    {
        //	mak_id smallint identity not null,
        //major_kind_id char (2) null,
        //major_kind_name varchar(60) null,
        //major_id char (2) null,
        //major_name varchar(60) null,
        //test_amount smallint null)  

        public int mak_id { get; set; }
        public string major_kind_id { get; set; }
        public string major_kind_name { get; set; }
        public string major_id { get; set; }
        public string major_name { get; set; }
        public int test_amount { get; set; }
    }
}
