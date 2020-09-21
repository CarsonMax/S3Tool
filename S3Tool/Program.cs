using S3Tool.Data;
using System;

namespace S3Tool
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            EFCoreDbContext dbContext = new EFCoreDbContext();
            //bool tfTrue = dbContext.Database.EnsureCreated();
            //if (tfTrue)
            //{
            //    Console.WriteLine("数据库创建成功!");
            //}
            //else
            //{
            //    Console.WriteLine("数据库创建失败!");
            //}

            Console.ReadKey();
        }
    }
}
