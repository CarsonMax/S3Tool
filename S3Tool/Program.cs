using S3Tool.Data;
using S3Tool.Models;
using System;
using System.Collections.Generic;

namespace S3Tool
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            EFCoreDbContext dbContext = new EFCoreDbContext();
            //bool tfDeleteTrue = dbContext.Database.EnsureDeleted();
            //if (tfDeleteTrue)
            //{
            //    Console.WriteLine("数据库删除成功!");
            //}
            //else
            //{
            //    Console.WriteLine("数据库删除失败!");
            //}
            //var tfTrue = dbContext.Database.EnsureCreated();
            //if (tfTrue)
            //{
            //    Console.WriteLine("数据库创建成功!");
            //}
            //else
            //{
            //    Console.WriteLine("数据库创建失败!");
            //}

            var gap = new GapEntity
            {
            };
            var attachments = new List<GapAttachmentEntity>
            {
                new GapAttachmentEntity{GapEntity = gap}
            };
            gap.Attachments = attachments;
            dbContext.GapEntities.Add(gap);

            dbContext.SaveChanges();

            Console.WriteLine("Test done");

            Console.ReadKey();
        }
    }
}
