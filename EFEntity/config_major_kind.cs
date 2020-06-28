using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFEntity
{
   public class config_major_kind
    {
        //       mfk_id smallint identity not null,
        //   major_kind_id char (2) null,
        //major_kind_name varchar(60) null)  
        public int mfk_id { get; set; }
        public string major_kind_id { get; set; }
        public string major_kind_name { get; set; }
    }
}
