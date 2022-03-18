namespace NerdySoft_task2.Service
{
    public static class Extensions
    {//Метод для обрізання закінчення у назві контроллерів
        public static string CutController(this string str)
        {
            return str.Replace("Controller", "");
        }
    }
}
