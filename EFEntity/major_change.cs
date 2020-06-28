using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFEntity
{
   public class major_change
    {
	//	mch_id smallint identity not null,
	//first_kind_id char (2) null,
	//first_kind_name varchar(60) null,
	//second_kind_id char (2) null,
	//second_kind_name varchar(60) null,
	//third_kind_id char (2) null,
	//third_kind_name varchar(60) null,
	//major_kind_id char (2) null,
	//major_kind_name varchar(60) null,
	//major_id char (2) null,
	//major_name varchar(60) null,
	//new_first_kind_id char (2) null,
	//new_first_kind_name varchar(60) null,
	//new_second_kind_id char (2) null,
	//new_second_kind_name varchar(60) null,
	//new_third_kind_id char (2) null,
	//new_third_kind_name varchar(60) null,
	//new_major_kind_id char (2) null,
	//new_major_kind_name varchar(60) null,
	//new_major_id char (2) null,
	//new_major_name varchar(60) null,
	//human_id varchar(30) null,
	//human_name varchar(60) null,
	//salary_standard_id varchar(30) null,
	//salary_standard_name varchar(60) null,
        public int mch_id { get; set; }
        public string first_kind_id { get; set; }
        public string first_kind_name { get; set; }
        public string second_kind_id { get; set; }
        public string second_kind_name { get; set; }
        public string third_kind_id { get; set; }
        public string third_kind_name { get; set; }
        public string major_id { get; set; }
        public string major_name { get; set; }
        public string new_first_kind_id { get; set; }
        public string new_first_kind_name { get; set; }
        public string new_second_kind_id { get; set; }
        public string new_second_kind_name { get; set; }
        public string new_third_kind_id { get; set; }
        public string new_third_kind_name { get; set; }
        public string new_major_kind_id { get; set; }
        public string new_major_kind_name { get; set; }
        public string new_major_id { get; set; }
        public string new_major_name { get; set; }
        public string human_id { get; set; }
        public string human_name { get; set; }
        public string salary_standard_id { get; set; }
        public string salary_standard_name { get; set; }
        //salary_sum money null,
        //new_salary_standard_id varchar(30) null,
        //new_salary_standard_name varchar(60) null,
        //new_salary_sum money null,
        //change_reason text null,
        //check_reason text null,
        //check_status smallint null,
        //register varchar(60) null,
        //checker varchar(60) null,
        //regist_time datetime null,
        //check_time datetime null)  
        public double salary_sum { get; set; }
        public string new_salary_standard_id { get; set; }
        public string new_salary_standard_name { get; set; }
        public double new_salary_sum { get; set; }
        public string change_reason { get; set; }
        public string check_reason { get; set; }
        public int check_status { get; set; }
        public string register { get; set; }
        public string checker { get; set; }
        public DateTime regist_time { get; set; }
        public DateTime check_time { get; set; }
    }
}
