using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace PolityBot
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Logger.ManagerLogger("bot enabled");
            CreateWebHostBuilder(args).Build().Run();
            
            //___________________________________________________________________
            using (helloappdbContext db = new helloappdbContext())
            {
                // �������� ������� �� �� � ������� �� �������
                var users = db.Users.ToList();
                Console.WriteLine("������ ��������:");
                foreach (Users u in users)
                {
                    Console.WriteLine($"{u.Id}.{u.Name} - {u.Age}");
                }
            }
            Console.ReadKey();
            //___________________________________________________________________





        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
