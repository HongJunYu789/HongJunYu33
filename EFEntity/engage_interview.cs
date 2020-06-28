using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFEntity
{
   public class engage_interview
    {
	//	ein_id smallint identity not null,
	//human_name varchar(60) null,
	//interview_amount smallint null,
	//human_major_kind_id char (2) null,
	//human_major_kind_name varchar(30) null,
	//human_major_id char (2) null,
	//human_major_name varchar(30) null,
	//image_degree varchar(20) null,
	//native_language_degree varchar(20) null,
	//foreign_language_degree varchar(20) null,
	//response_speed_degree varchar(20) null,
	//EQ_degree varchar(20) null,
	//IQ_degree varchar(20) null,
	//multi_quality_degree varchar(20) null,
	//register varchar(60) null,
	//checker varchar(60) null,
	//registe_time datetime null,
	//check_time datetime null,
	//resume_id smallint null,
	//result varchar(20) null,
	//interview_comment text null,
	//check_comment text null,
	//interview_status smallint null,
	//check_status smallint null)  
        public int ein_id { get; set; }
        public string human_name { get; set; }
        public int interview_amount { get; set; }
        public string human_major_kind_id { get; set; }
        public string human_major_kind_name { get; set; }
        public string human_major_id { get; set; }
        public string human_major_name { get; set; }
        public string image_degree { get; set; }
        public string native_language_degree { get; set; }
        public string foreign_language_degree { get; set; }
        public string response_speed_degree { get; set; }
        public string EQ_degree { get; set; }
        public string IQ_degree { get; set; }
        public string multi_quality_degree { get; set; }
        public string register { get; set; }
        public string checker { get; set; }
        public DateTime registe_time { get; set; }
        public DateTime check_time { get; set; }
        public int resume_id { get; set; }
        public string result { get; set; }
        public string interview_comment { get; set; }
        public string check_comment { get; set; }
        public int interview_status { get; set; }
        public int check_status { get; set; }
    }
}
