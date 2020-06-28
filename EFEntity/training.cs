using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFEntity
{
public    class training
    {
	//	tra_id smallint identity not null,
	//major_kind_id char (2) null,
	//major_kind_name varchar(60) null,
	//major_id char (2) null,
	//major_name varchar(60) null,
	//human_id varchar(30) null,
	//human_name varchar(60) null,
	//training_item varchar(60) null,
	//training_time datetime null,
	//training_hour int null,
	//training_degree varchar(60) null,
	//register varchar(60) null,
	//checker varchar(60) null,
	//regist_time datetime null,
	//check_time datetime null,
	//checkstatus smallint null,
	//remark text null)  
        public int tra_id { get; set; }
        public string major_kind_id { get; set; }
        public string major_kind_name { get; set; }
        public string human_id { get; set; }
        public string human_name { get; set; }
        public string training_item { get; set; }
        public DateTime MyProptraining_timeerty { get; set; }
        public string register { get; set; }
        public string checker { get; set; }
        public DateTime regist_time { get; set; }
        public DateTime check_time { get; set; }
        public int checkstatus { get; set; }
        public string remark { get; set; }
    }
}
