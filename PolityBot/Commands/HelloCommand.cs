using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace PolityBot.Commands
{
    public class HelloCommand : ICommand
    {
        public List<string> Allias { get; } = new List<string> { "привет" };
        public string Result { get; set; }

        public async Task Execute(string param)
        {
            Result = "Привет";
        }

        public bool CanExecute(string msg) { return true; }
    }
}
