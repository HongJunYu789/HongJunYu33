using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFEntity
{
   public class salary_grant
    {
	//	sgr_id smallint identity not null,
	//salary_grant_id varchar(30) null,
	//salary_standard_id varchar(30) null,
	//first_kind_id char (2) null,
	//first_kind_name varchar(60) null,
	//second_kind_id char (2) null,
	//second_kind_name varchar(60) null,
	//third_kind_id char (2) null,
	//third_kind_name varchar(60) null,
	//human_amount smallint null,
	//salary_standard_sum money null,
	//salary_paid_sum money null,
	//register varchar(60) null,
	//regist_time datetime null,
	//checker varchar(60) null,
	//check_time datetime null,
	//check_status smallint null)  
        public int sgr_id { get; set; }
        public string salary_grant_id { get; set; }
        public string salary_standard_id { get; set; }
        public string first_kind_id { get; set; }
        public string first_kind_name { get; set; }
        public string second_kind_id { get; set; }
        public string second_kind_name { get; set; }
        public string third_kind_id { get; set; }
        public string third_kind_name { get; set; }
        public int human_amount { get; set; }
        public double salary_standard_sum { get; set; }
        public string register { get; set; }
        public DateTime regist_time { get; set; }
        public string checker { get; set; }
        public DateTime check_time { get; set; }
        public int check_status { get; set; }
    }
}
