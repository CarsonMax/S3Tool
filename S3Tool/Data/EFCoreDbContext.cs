using Microsoft.EntityFrameworkCore;
using S3Tool.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace S3Tool.Data
{

    /// <summary>
    /// 数据上下文类，继承自DbContext
    /// </summary>
    public class EFCoreDbContext : DbContext
    {
        /// <summary>
        /// 重写OnConfiguring方法
        /// </summary>
        /// <param name="optionsBuilder"></param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // 使用SqlServer数据库，传递连接字符串
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=EFTestDb;User ID=sa;Password=sa1234;");
            base.OnConfiguring(optionsBuilder);
        }

        /// <summary>
        /// 重写OnModelCreating，主要做一些配置
        /// 例如设置生成的表名、主键、字符长度
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // 设置生成的表名
            modelBuilder.Entity<Student>().ToTable("T_Student");
            // 设置主键，可以不设置，会默认把Id字段当成主键
            modelBuilder.Entity<Student>().HasKey(p => p.Id);
            // 设置Name字段的最大长度
            modelBuilder.Entity<Student>().Property("Name").HasMaxLength(32);

            //gap
            modelBuilder.Entity<GapEntity>().ToTable("EXT_GAP_INITIATIVES")
                .HasKey(g => g.ID);
            modelBuilder.Entity<GapEntity>().HasMany(g => g.Attachments).WithOne(ga => ga.GapEntity).HasForeignKey(g => g.GAP_ID);
            modelBuilder.Entity<GapAttachmentEntity>().ToTable("EXT_GAP_INITIATIVE_ATTACHMENT")
                .HasKey(ga => ga.ID);

            base.OnModelCreating(modelBuilder);
        }

        // DbSet属性
        public DbSet<Student> Students { get; set; }

        public DbSet<GapEntity> GapEntities { get; set; }
    }
}
