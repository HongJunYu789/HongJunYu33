using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFEntity
{
   public class salary_standard
    {
        //	ssd_id smallint identity not null,
        //standard_id varchar(30) null,
        //standard_name varchar(60) null,
        //designer varchar(60) null,
        //register varchar(60) null,
        //checker varchar(60) null,
        //changer varchar(60) null,
        //regist_time datetime null,
        //check_time datetime null,
        //change_time datetime null,
        //salary_sum money null,
        //check_status smallint null,
        //change_status smallint null,
        //check_comment text null,
        //remark text null)  
        [Key]
        public int ssd_id { get; set; }

        public string standard_id { get; set; }
        public string standard_name { get; set; }
        public string designer { get; set; }
        public string register { get; set; }
        public string checker { get; set; }
        public string changer { get; set; }
        public DateTime regist_time { get; set; }
        public DateTime check_time { get; set; }
        public DateTime change_time { get; set; }
        public double salary_sum { get; set; }
        public int check_status { get; set; }
        public int change_status { get; set; }
        public string check_comment { get; set; }
        public string remark { get; set; }
    }
}
