using DR.Data.Mysql.Transaction.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DR.Data.Mysql.Transaction
{

    public class TransactionContext : DbContext
    {
        public TransactionContext(DbContextOptions<TransactionContext> options)
  : base(options)
        {
           
        }

        public DbSet<UWallert> UWallert { get; set; }

        public DbSet<DDepositType> DDepositType { get; set; }

        public DbSet<DPayDetailType> DPayDetailType { get; set; }

        public DbSet<DPayType> DPayType { get; set; }

        public DbSet<DBank> DBank { get; set; }
    }

}
