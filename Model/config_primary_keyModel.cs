using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
  public  class config_primary_keyModel
    {
        public int prk_id { get; set; }
        public string primary_key_table { get; set; }
        public string primary_key { get; set; }
        public string key_name { get; set; }
        public bool primary_key_status { get; set; }
    }
}
