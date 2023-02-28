using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;

//namespace DAL.DataContext
//{
//    public class DatabaseContextFactory:IDesignTimeDbContextFactory<Gcom2Context>
//    {
//        public Gcom2Context CreateDbContext(string[] args)
//        {
//            AppConfiguration appConfig = new AppConfiguration();
//            var opsBuilder = new DbContextOptionsBuilder<Gcom2Context>();
//            opsBuilder.UseSqlServer(appConfig.sqlConnectionString);
//            return new Gcom2Context(opsBuilder.Options);
//        }
//    }
//}
