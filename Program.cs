using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Linq;

namespace PolityBot
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Logger.ManagerLogger("bot enabled");
            try
            {
                using (TodoContext db = new TodoContext())
                {
                    // получаем объекты из бд и выводим на консоль
                    var users = db.UsersItem.ToList();
                    Logger.ManagerLogger("Список объектов:");

                    if (users.Count() == 0)
                        Logger.ManagerLogger(0);

                    foreach (UsersItem u in users)
                    {
                        Logger.ManagerLogger($"{u.Id}.{u.Name} - {u.Age}");
                    }
                }
            } catch (Exception ex) { Logger.ManagerLogger(ex); }
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
