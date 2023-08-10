using SD.LLBLGen.Pro.ORMSupportClasses;

namespace TestApi.Common
{
    public class ConnectionStrings
    {
        public string Base_ConnectionString { get; set; }
    }

    public class Authorize
    {
        public string DefaultScheme { get; set; }
        public string ClientName { get; set; }
        public string ClientSecret { get; set; }
        public string Authority { get; set; }
    }

    public class FileLocation
    {
        public string Path { get; set; }
        public double MaxSize { get; set; }
        public string LogPath { get; set; }
    }

    public class logEx
    {
        public Boolean Log { get; set; } = false;
    }

    #region Declare AppConfig
    public partial class AppSettingModel
    {
        public ConnectionStrings ConnectionStrings { get; set; }
        public Authorize Authorize { get; set; }
        public string Secret { get; set; }
        public string ApiName { get; set; }
        public string ServiceProtocol { get; set; }
        public string BaseSwaggerEndpoint { get; set; }
        public string BaseSwaggerEndpointDoc { get; set; }
        public string[] AllowOrigins { get; set; }
        public FileLocation FileLocation { get; set; }
        public AppSettingModel()
        {
            LogEx = new logEx();
        }
        public logEx LogEx { get; set; }
        public Login LoginModel { get; set; }



        public class Login
        {
            public string UserName { get; set; }
            public string PassWord { get; set; }
        }

        public class SchedulerJob
        {
            public int? Hour { get; set; }
            public int? Minute { get; set; }
        }
        public class Scheduler
        {
            public string NotificationForPoliceJob { get; set; }
            public string PingJob { get; set; }
            public string TemporaryCheckJob { get; set; }
        }

    }
    #endregion
}
