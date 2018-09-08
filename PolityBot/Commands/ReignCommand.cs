using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PolityBot.Commands
{
    public class ReignCommand : ICommand
    {




        public List<string> Alias { get; } = new List<string> { "Власть" , "Кто тут власть", "Кто здесь власть", "Кто сдесь власть", "А судьи кто", "А судьи ктт", };

        public string Name { get; } = "Власть";



        public string Description { get; } = "Нахуй описание, потом придумаем";

        public string Example { get; } = $"{BotConfig.BotName}Власть";

        public string Result { get; } = "123321312321";


        public bool CanExecute { get; } = false;


        //_________________________________________________________________________________________________________________
        public List<string> Allias => throw new NotImplementedException();

        public Task Execute(string param)
        {
            throw new NotImplementedException();
        }                                                                          // Хуйня временная чтобы ошибок не было,                                                                                     
                                                                                   // и запустить можно было,
        bool ICommand.CanExecute(string msg)                                       // удали короче это все
        {
            throw new NotImplementedException();
        }
        //_________________________________________________________________________________________________________________


    }
}