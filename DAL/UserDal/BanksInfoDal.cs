using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Entities.Concrete;

namespace DAL.UserDal
{
    public class BanksInfoDal : EntityTypeConfiguration<BankInfo>
    {
        public BanksInfoDal()
        {
            ToTable("userBank");
            Property(x => x.BankName).IsRequired().HasColumnName("Bank Name");
            Property(x => x.ChooseBank).IsRequired().HasColumnName("Choose A Bank").IsOptional();
            Property(x => x.BankNum).IsRequired().HasColumnName("Bank Number");
            HasKey(x => x.BankID);

        }

        public object BankID { get; private set; }
    }
}
