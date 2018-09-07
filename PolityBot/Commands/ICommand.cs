
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
    }
}
