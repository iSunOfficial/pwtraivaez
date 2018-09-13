using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PolityBot.Commands
{
    public class CommandList
    {
        private static readonly List<ICommand> Commands;

        static CommandList()
        {
            Commands = new List<ICommand>
            {
                new HelloCommand(),
            };

        }

        public static string ErrorMessage = "Ошибочка, проверьте правильность написания команды!";

        public static string ExecuteCommand(VkNet.Model.Message msg)
        {
            msg.Text = msg.Text.Remove(0, 1);
            Logger.ManagerLogger(msg.Text);
            var result = ErrorMessage;
            try
            {
                foreach (var command in Commands)
                {
                    if (!command.Allias.Contains(msg.Text)) continue;

                    if (command.CanExecute(msg.Text))
                        command.Execute(msg.Text);

                    result = command.Result;
                    break;
                }
                
            } catch (Exception ex)
            {
                Logger.ManagerLogger(ex);
            }
            return result;
        }
    }
}