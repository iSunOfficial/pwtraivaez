using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace PolityBot.Commands
{
    public class HelloCommand : ICommand
    {
        public List<string> Allias { get; } = new List<string> { "привет", };

        public string Name { get; } = "Привет";



        public string Description { get; } = "Нахуй описание, потом придумаем";

        public string Example { get; } = $"{BotConfig.BotName}Привет";


        public async Task Execute(string param)
        {
            Result = "Привет";
        }

        public string Result { get; set; }

        public bool CanExecute(string msg) { return true; }

        public byte Rangs { get; } = 0;
    }
}
