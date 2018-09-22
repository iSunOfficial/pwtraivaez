using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace PolityBot.Commands
{
    public class BUND : ICommand
    {
        public List<string> Allias { get; } = new List<string> { "Бунт", "Бунд", "Бунт блять", "Бунд блять", "Бунт блядь", "Бунд блядь", };

        public string Name { get; } = "Бунд";



        public string Description { get; } = "Нахуй описание, потом придумаем";

        public string Example { get; } = $"{BotConfig.BotName}Бунд";


        public async Task Execute(string param)
        {
            Result = "Ты бунданул. Ну круто";
        }

        public string Result { get; set; }

        public bool CanExecute(string msg) { return true; }

        public byte Rangs { get; } = 1;
    }
}
