using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFEntity
{
  public  class salary_grant_details
    {
        //	grd_id smallint identity not null,
        //salary_grant_id varchar(30) null,
        //human_id varchar(30) null,
        //human_name varchar(60) null,
        //bouns_sum money null,
        //sale_sum money null,
        //deduct_sum money null,
        //salary_standard_sum money null,
        //salary_paid_sum money null)  
        public int grd_id { get; set; }
        public string salary_grant_id { get; set; }
        public string human_id { get; set; }
        public string human_name { get; set; }
        public double bouns_sum { get; set; }
        public double sale_sum { get; set; }
        public double deduct_sum { get; set; }
        public double salary_standard_sum { get; set; }
        public double salary_paid_sum { get; set; }

    }
}
