using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFEntity
{
   public class human_file
    {
	//	huf_id smallint identity not null,
	//human_id varchar(30) null,
	//first_kind_id char (2) null,
	//first_kind_name varchar(60) null,
	//second_kind_id char (2) null,
	//second_kind_name varchar(60) null,
	//third_kind_id char (2) null,
	//third_kind_name varchar(60) null,
	//human_name varchar(60) null,
	//human_address varchar(200) null,
	//human_postcode varchar(10) null,
	//human_pro_designation varchar(60) null,
	//human_major_kind_id char (2) null,
	//human_major_kind_name varchar(60) null,
	//human_major_id char (2) null,
	//hunma_major_name varchar(60) null,
	//human_telephone varchar(20) null,
	//human_mobilephone char (11) null,
	//human_bank varchar(50) null,
	//human_account varchar(30) null,
        public int huf_id { get; set; }
        public string human_id { get; set; }
        public string first_kind_id { get; set; }
        public string first_kind_name { get; set; }
        public string second_kind_id { get; set; }
        public string second_kind_name { get; set; }
        public string third_kind_id { get; set; }
        public string third_kind_name { get; set; }
        public string human_name { get; set; }
        public string human_address { get; set; }
        public string human_postcode { get; set; }
        public string human_pro_designation { get; set; }
        public string human_major_kind_id { get; set; }
        public string human_major_kind_name { get; set; }
        public string human_major_id { get; set; }
        public string hunma_major_name { get; set; }
        public string human_telephone { get; set; }
        public string human_mobilephone { get; set; }
        public string human_bank { get; set; }
        public string human_account { get; set; }
        //	human_qq varchar(15) null,
        //human_email varchar(50) null,
        //human_hobby varchar(60) null,
        //human_speciality varchar(60) null,
        //human_sex char (2) null,
        //human_religion varchar(50) null,
        //human_party varchar(50) null,
        //human_nationality varchar(50) null,
        //human_race varchar(50) null,
        //human_birthday datetime null,
        //human_birthplace varchar(50) null,
        //human_age smallint null,
        //human_educated_degree varchar(60) null,
        //human_educated_years smallint null,
        //human_educated_major varchar(60) null,
        //human_society_security_id varchar(30) null,
        //human_id_card varchar(20) not null,
        //remark text null,
        //salary_standard_id varchar(30) null,
        //salary_standard_name varchar(60) null,
        //salary_sum money null,
        //demand_salaray_sum money null,
        //paid_salary_sum money null,
        //major_change_amount smallint null,
        public string human_qq { get; set; }
        public string human_email { get; set; }
        public string human_hobby { get; set; }
        public string human_speciality { get; set; }
        public string human_sex { get; set; }
        public string human_religion { get; set; }
        public string human_party { get; set; }
        public string human_nationality { get; set; }
        public string human_race { get; set; }
        public DateTime human_birthday { get; set; }
        public string human_birthplace { get; set; }
        public int human_age { get; set; }
        public string human_educated_degree { get; set; }
        public int human_educated_years { get; set; }
        public string human_educated_major { get; set; }
        public string human_society_security_id { get; set; }
        public string human_id_card { get; set; }
        public string remark { get; set; }
        public string salary_standard_id { get; set; }
        public string salary_standard_name { get; set; }
        public double paid_salary_sum { get; set; }
        public int major_change_amount { get; set; }
        //       bonus_amount smallint null,
        //   training_amount smallint null,
        //file_chang_amount smallint null,
        //   human_histroy_records text null,
        //human_family_membership text null,
        //   human_picture varchar(255) null,
        //attachment_name varchar(255) null,
        //check_status smallint null,
        //   register varchar(60) null,
        //checker varchar(60) null,
        //changer varchar(60) null,
        //regist_time datetime null,
        //   check_time datetime null,
        //change_time datetime null,
        //   lastly_change_time datetime null,
        //delete_time datetime null,
        //   recovery_time datetime null,
        //human_file_status bit null)  
        public int bonus_amount { get; set; }
        public int training_amount { get; set; }
        public int file_chang_amount { get; set; }
        public string human_histroy_records { get; set; }
        public string human_family_membership { get; set; }
        public string human_picture { get; set; }
        public string attachment_name { get; set; }
        public int check_status { get; set; }
        public string register { get; set; }
        public string checker { get; set; }
        public string changer { get; set; }
        public DateTime regist_time { get; set; }
        public DateTime check_time { get; set; }
        public DateTime change_time { get; set; }
        public DateTime lastly_change_time { get; set; }
        public DateTime delete_time { get; set; }
        public DateTime recovery_time { get; set; }
        public int human_file_status { get; set; }
    }
}
