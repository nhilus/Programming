//using Microsoft.Extensions.Configuration;


//namespace DAL.DataContext
//{
//    public class AppConfiguration
//    {
//        public AppConfiguration() 
//        {
//            var configBuilder = new ConfigurationBuilder();
//            var path = Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json");
//            configBuilder.AddJsonFile(path, false);
//            var root = configBuilder.Build();
//            var appSetting = root.GetSection("ConnectionStrings:GCOM2DbContext");
//            sqlConnectionString = appSetting.Value;
//        }
//        public string sqlConnectionString { get; set; }
//    }
//}
