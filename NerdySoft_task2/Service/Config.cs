namespace NerdySoft_task2.Service
{
    public class Config
    {//Метод для передачі стрічки підключення і інформації з appsettings
        public static string ConnectionString { get; set; }
        public static string CompanyName { get; set; }
        public static string CompanyPhone { get; set; }
        public static string CompanyEmail { get; set; }
    }
}
