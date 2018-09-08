using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace PolityBot.Commands
{
    public class PasportCommand : ICommand 
    {
        public List<string> Allias { get; } = new List<string> { "паспорт", "пасспорт", "паспарт", "пасспарт", "паспорь", };

        public string Name { get; } = "паспорт";



        public string Description { get; } = "Нахуй описание, потом придумаем";

        public string Example { get; } = $"{BotConfig.BotName}паспорт";


        public async Task Execute(string param)
        {
            Result = "Твой паспорт";
        }

        public string Result { get; set; }

        public bool CanExecute(string msg) { return true; }


    }
}
