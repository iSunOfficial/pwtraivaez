using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PolityBot.Commands
{
    public class RegistrationCommand : ICommand 
    {
      public string Name { get; } = "Регистрация";

      public string Description { get; } = "Нахуй описание, потом придумаем";

      public string Example { get; } = $"{BotConfig.BotName}Кто я";

        //   public List Allias { get; } = {"aaa"};   не ебу как листы делать, потом читану 

        public string Result { get; } = "123321312321";

        //    public Task Execute { get; } = false;       тож не ебу, таск какойта

        public bool CanExecute { get; } = false;








    }
}
