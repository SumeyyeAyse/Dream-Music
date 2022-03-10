using System.Data.Entity;
using DAL.UserDal;
using Entities.Concrete;

namespace DAL.ConcreteDal.Context
{
    public class UsersContex:DbContext
    {
        public UsersContex() : base("Users")
        {
            Database.Connection.ConnectionString = "Server = DESKTOP-7DAI8NE\\MSSQLSERVER01; Database = AboneDB; Trusted_Connection = True;";
        }

        public DbSet<UserInfo> UserInfos { get; set; }
        public DbSet<BankInfo> BankInfos { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new BanksInfoDal());
            modelBuilder.Configurations.Add(new UsersInfoDal());


            base.OnModelCreating(modelBuilder);
        }

    }
}
