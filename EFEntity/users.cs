using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFEntity
{
  public  class users
    {
        [Key]
        public int user_id { get; set; }
        public string user_name { get; set; }
        public string user_true_name { get; set; }
        public string user_password { get; set; }
    }
}
