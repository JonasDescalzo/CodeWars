using DR.Data.Mysql.UserAuth.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DR.Data.Mysql.UserAuth
{
    public class UserAuthContext : DbContext
    {
        public UserAuthContext(DbContextOptions<UserAuthContext> options)
  : base(options)
        {
           
        }

        public DbSet<Aff> Aff { get; set; }

        public DbSet<DTransaction> DTransaction { get; set; }

        public DbSet<DTransactionError> DTransactionError { get; set; }

        public DbSet<Users> Users { get; set; }
        public DbSet<UserRank> UserRanks { get; set; }

        public DbSet<AffDomain> AffDomain { get; set; }

        public DbSet<UserLevel> UserLevel { get; set; }

        public DbSet<UserGroup> UserGroup { get; set; }

        public DbSet<UserRegisterGift> UserRegisterGift { get; set; }

        public DbSet<UsersBank> UsersBank { get; set; }

        public DbSet<BankList> BankList { get; set; }

        public DbSet<UserBankLog> UserBankLog { get; set; }

        public DbSet<UserInvite> UserInvite { get; set; }

        public DbSet<UserWashcode> UserWashcode { get; set; }

        public DbSet<UserWashCodeType> UserWashCodeType { get; set; }

        public DbSet<UsersStationLetter> UsersStationLetter { get; set; }

        public DbSet<UsersLetterRead> UsersLetterRead { get; set; }

        public DbSet<AntMenu> AntMenu { get; set; }

        public DbSet<AntAmdin> AntAmdin { get; set; }

        public DbSet<AntPermission> AntPermission { get; set; }

        public DbSet<AntRelationship> AntRelationship { get; set; }

        public DbSet<AntRole> AntRole { get; set; }

        public DbSet<UserStatisticsDate> UserStatisticsDate { get; set; }

        public DbSet<UserInviteBonus> UserInviteBonus { get; set; }

        public DbSet<AffCommission> AffCommission { get; set; }

        public DbSet<AffDateData> AffDateData { get; set; }

        public DbSet<UsersNeedBill> UsersNeedBill { get; set; }

        public DbSet<Country> Country { get; set; }
        public DbSet<Merchant> Merchants { get; set; }

        public DbSet<UsersInformation> UsersInformation { get; set; }
        public DbSet<AffWallet> AffWallet { get; set; }

        public DbSet<UsersTKLog> UsersTKLog { get; set; }

    }
}
