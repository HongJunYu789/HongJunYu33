using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EFEntity
{
    public class TextDbContent:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            //Server=.\\sql20122;Database=dbCore;User ID=sa;Password=123;
            //Data Source=LAPTOP-A70OLK3H;Initial Catalog=LLL;Integrated Security=True
            //Server=LAPTOP-A70OLK3H\\FF;Database=dbCore;Integrated Security=True
            optionsBuilder.UseSqlServer("Data Source=LAPTOP-A70OLK3H;Initial Catalog=DiaoMao;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //写对应的配置信息
            var cffk = modelBuilder.Entity<users>();
            cffk.ToTable(nameof(users));
            cffk.HasKey("user_id");

            var zzz = modelBuilder.Entity<config_file_first_kind>();
            zzz.ToTable(nameof(config_file_first_kind));
            zzz.HasKey("ffk_id");

            var ccc = modelBuilder.Entity<config_file_second_kind>();
            ccc.ToTable(nameof(config_file_second_kind));
            ccc.HasKey("fsk_id");

            var ddd = modelBuilder.Entity<config_file_third_kind>();
            ddd.ToTable(nameof(config_file_third_kind));
            ddd.HasKey("ftk_id");

            var fff = modelBuilder.Entity<config_major>();
            fff.ToTable(nameof(config_major));
            fff.HasKey("mak_id");

            var lll = modelBuilder.Entity<config_major_kind>();
            lll.ToTable(nameof(config_major_kind));
            lll.HasKey("mfk_id");

            var ooo = modelBuilder.Entity<config_public_char>();
            ooo.ToTable(nameof(config_public_char));
            ooo.HasKey("pbc_id");

            var aaa = modelBuilder.Entity<bouns>();
            aaa.ToTable(nameof(bouns));
            aaa.HasKey("bon_id");

            var bbb = modelBuilder.Entity<config_primary_key>();
            bbb.ToTable(nameof(config_primary_key));
            bbb.HasKey("prk_id");

            var eee = modelBuilder.Entity<config_question_first_kind>();
            eee.ToTable(nameof(config_question_first_kind));
            eee.HasKey("qfk_id");

            var hhh = modelBuilder.Entity<config_question_second_kind>();
            hhh.ToTable(nameof(config_question_second_kind));
            hhh.HasKey("qsk_id");

            var iii = modelBuilder.Entity<engage_answer>();
            iii.ToTable(nameof(engage_answer));
            iii.HasKey("ans_id");

            var jjj =  modelBuilder.Entity<engage_answer_details>();
            jjj.ToTable(nameof(engage_answer_details));
            jjj.HasKey("and_id");

            var kkk = modelBuilder.Entity<engage_exam>();
            kkk.ToTable(nameof(engage_exam));
            kkk.HasKey("exa_id");

            var mmm = modelBuilder.Entity<engage_exam_details>();
            mmm.ToTable(nameof(engage_exam_details));
            mmm.HasKey("exd_id");

            var nnn = modelBuilder.Entity<engage_interview>();
            nnn.ToTable(nameof(engage_interview));
            nnn.HasKey("ein_id");


            var nsafann = modelBuilder.Entity<engage_major_release>();
            nsafann.ToTable(nameof(engage_major_release));
            nsafann.HasKey("mre_id");

            var nsascfann = modelBuilder.Entity<engage_resume>();
            nsascfann.ToTable(nameof(engage_resume));
            nsascfann.HasKey("res_id");

            var nsascfavann = modelBuilder.Entity<engage_subjects>();
            nsascfavann.ToTable(nameof(engage_subjects));
            nsascfavann.HasKey("sub_id");

            var nsacfavann = modelBuilder.Entity<human_file>();
            nsacfavann.ToTable(nameof(human_file));
            nsacfavann.HasKey("huf_id");

            var nsacfavan = modelBuilder.Entity<human_file_dig>();
            nsacfavan.ToTable(nameof(human_file_dig));
            nsacfavan.HasKey("hfd_id");


            var nsacfavn = modelBuilder.Entity<major_change>();
            nsacfavn.ToTable(nameof(major_change));
            nsacfavn.HasKey("mch_id");

            var nscfavn = modelBuilder.Entity<salary_grant>();
            nscfavn.ToTable(nameof(salary_grant));
            nscfavn.HasKey("sgr_id");


            var ncfavn = modelBuilder.Entity<salary_grant_details>();
            ncfavn.ToTable(nameof(salary_grant_details));
            ncfavn.HasKey("grd_id");

            var ncfav = modelBuilder.Entity<salary_standard>();
            ncfav.ToTable(nameof(salary_standard));
            ncfav.HasKey("ssd_id");

            var ncfafv = modelBuilder.Entity<salary_standard_details>();
            ncfafv.ToTable(nameof(salary_standard_details));
            ncfafv.HasKey("sdt_id");

            var ncfafva = modelBuilder.Entity<training>();
            ncfafva.ToTable(nameof(training));
            ncfafva.HasKey("tra_id");

        }

        public DbSet<bouns> Bo { get; set; }
        public DbSet<config_file_first_kind> Cffk { get; set; }

        public DbSet<config_file_second_kind> Cfsk { get; set; }

        public DbSet<config_file_third_kind> Cftk { get; set; }

        public DbSet<config_major> Cm { get; set; }

        public DbSet<config_major_kind> Cmk { get; set; }

        public DbSet<config_primary_key> Cpk { get; set; }

        public DbSet<config_public_char> Cpc { get; set; }
        public DbSet<config_question_first_kind> Cqfk { get; set; }
        public DbSet<config_question_second_kind> Cqsk { get; set; }
        public DbSet<engage_answer> Ea { get; set; }
        public DbSet<engage_answer_details> Ead { get; set; }
        public DbSet<engage_exam> Ee { get; set; }
        public DbSet<engage_exam_details> Eed { get; set; }
        public DbSet<engage_interview> Ei { get; set; }



        public DbSet<engage_major_release> Emr { get; set; }

        public DbSet<engage_resume> Er { get; set; }
        public DbSet<engage_subjects> Es{ get; set; }

        public DbSet<human_file> Hf { get; set; }
        public DbSet<human_file_dig> Hfd { get; set; }
        public DbSet<major_change> Mc { get; set; }
        public DbSet<salary_grant> Sg { get; set; }
        public DbSet<salary_grant_details> Sgd { get; set; }
        //salary_standard_detailsModel
        public DbSet<salary_standard_details> Ssd { get; set; }
        public DbSet<training> Tr { get; set; }
        public DbSet<users> Us { get; set; }

        public DbSet<salary_standard> Ss { get; set; }
    }
}
