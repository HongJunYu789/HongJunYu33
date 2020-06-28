using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFEntity
{
  public  class engage_resume
    {
        //	res_id smallint identity not null,
        //human_name varchar(60) null,
        //engage_type varchar(30) null,
        //human_address varchar(200) null,
        //human_postcode varchar(10) null,
        //human_major_kind_id char (2) null,
        //human_major_kind_name varchar(60) null,
        //human_major_id char (2) null,
        //human_major_name varchar(60) null,
        //human_telephone varchar(60) null,
        //human_homephone varchar(60) null,
        //human_mobilephone varchar(60) null,
        //human_email varchar(60) null,
        //human_hobby varchar(200) null,
        //human_specility varchar(200) null,
        //human_sex char (2) null,
        //human_religion varchar(60) null,
        //human_party varchar(60) null,
        //human_nationality varchar(60) null,
        //human_race varchar(60) null,
        //human_birthday datetime null,
        //human_age smallint null,
        //human_educated_degree varchar(60) null,
        //human_educated_years smallint null,
        //human_educated_major varchar(60) null,
        //human_college varchar(60) null,
        //human_idcard varchar(60) null,
        //human_birthplace varchar(200) null,
        //demand_salary_standard numeric(15,2) null,
        //human_history_records text null,
        public int res_id { get; set; }
        public string human_name { get; set; }
        public string engage_type { get; set; }
        public string human_address { get; set; }
        public string human_postcode { get; set; }
        public string human_major_kind_id { get; set; }
        public string human_major_kind_name { get; set; }
        public string human_major_id { get; set; }
        public string human_major_name { get; set; }
        public string human_telephone { get; set; }
        public string human_homephone { get; set; }
        public string human_mobilephone { get; set; }
        public string human_email { get; set; }
        public string human_hobby { get; set; }
        public string human_specility { get; set; }
        public string human_party { get; set; }
        public string human_sex { get; set; }
        public string human_religion { get; set; }
        public string human_nationality { get; set; }
        public string human_race { get; set; }
        public DateTime human_birthday { get; set; }
        public int human_age { get; set; }
        public string human_educated_degree { get; set; }
        public int human_educated_years { get; set; }
        public string human_educated_major { get; set; }
        public string human_college { get; set; }
        public string human_idcard { get; set; }
        public string human_birthplace { get; set; }
        public double demand_salary_standard { get; set; }
        public string human_history_records { get; set; }
        //remark text null,
        //   recomandation text null,
        //human_picture varchar(60) null,
        //attachment_name varchar(60) null,
        //check_status smallint null,
        //   register varchar(60) null,
        //regist_time datetime null,
        //   checker varchar(60) null,
        //check_time datetime null,
        //   interview_status smallint null,
        //total_points float null,
        //test_amount smallint null,
        //   test_checker varchar(60) null,
        //test_check_time datetime null,
        //   pass_register varchar(60) null,
        //pass_regist_time datetime null,
        //   pass_checker varchar(60) null,
        //pass_check_time datetime null,
        //   pass_check_status smallint null,
        //pass_checkComment varchar(60) null,
        //pass_passComment varchar(60) null
        public string remark { get; set; }
        public string recomandation { get; set; }
        public string human_picture { get; set; }
        public string attachment_name { get; set; }
        public int check_status { get; set; }
        public string register { get; set; }
        public DateTime regist_time { get; set; }
        public string checker { get; set; }
        public DateTime check_time { get; set; }
        public int interview_status { get; set; }
        public double total_points { get; set; }
        public int test_amount { get; set; }
        public string test_checker { get; set; }
        public DateTime test_check_time { get; set; }
        public string pass_register { get; set; }
        public DateTime pass_regist_time { get; set; }
        public string pass_checker { get; set; }
        public DateTime pass_check_time { get; set; }
        public int pass_check_status { get; set; }
        public string pass_checkComment { get; set; }
        public string pass_passComment { get; set; }
    }
}
