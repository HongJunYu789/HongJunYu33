using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFEntity
{
   public class config_primary_key
    {
        //	prk_id smallint identity not null,
        //primary_key_table varchar(60) null,
        //primary_key varchar(60) null,
        //key_name varchar(60) null,
        //primary_key_status bit null)  
        public int prk_id { get; set; }
        public string primary_key_table { get; set; }
        public string primary_key { get; set; }
        public string key_name { get; set; }
        public bool primary_key_status { get; set; }
    }
}
