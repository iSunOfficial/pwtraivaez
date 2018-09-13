
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PolityBot.Commands
{
    interface ICommand
    {
        List<string> Allias { get; }
        string Result { get; }

        Task Execute(string param);
        bool CanExecute(string msg);

       string Name { get; }                       // Название команды
       string Description { get; }                // Описание команды
       string Example { get; }                    // Как ее использовать


    }
}
