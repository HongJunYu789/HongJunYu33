using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFEntity
{
 public   class config_public_char
    {
        //       pbc_id smallint identity not null,
        //   attribute_kind varchar(60) ,
        //attribute_name varchar(60) )  
        public int pbc_id { get; set; }
        public string attribute_kind { get; set; }
        public string attribute_name { get; set; }
    }
}
