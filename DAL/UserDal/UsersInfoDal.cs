using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Entities.Concrete;

namespace DAL.UserDal
{
    public class UsersInfoDal : EntityTypeConfiguration<UserInfo>
    {
        public UsersInfoDal()
        {
            ToTable("users");
            Property(x => x.UsersName).IsRequired().HasColumnName("Name");
            Property(x => x.UsersSurname).IsRequired().HasColumnName("Surname");
            Property(x => x.UsersPhoneNum).IsRequired().HasColumnName("PNumber").IsOptional();
            Property(x => x.UsersEmail).IsRequired().HasColumnName("Email");
            HasKey(x => x.UsersID);
            /*Property(x => x.BankInfos).IsRequired().HasColumnName("BankID");
            Property(x => x.UsersCBank).IsVariableLength(5);
            Property(x => x.UsersBankNum).IsRequired().HasColumnName("BankNum");*/

        }
    }
}
