using System;
using PolityBot.VK;
namespace PolityBot
{
    public class Logger
    {

        public static void ManagerLogger(object message) => Common.GetGroupVkApi().Messages.Send(new VkNet.Model.RequestParams.MessagesSendParams { Message = $"[{DateTime.Now}]\n{message}", PeerId = 2_000_000_000 + 1 });

        public static void ErrorLogger(VkNet.Model.Message message, Exception ex)
        {
            MessageExt.MessageSend(api: Common.GetGroupVkApi(), data: message, message: "Произошла какая-то ошибка. Попробуйте еще раз!", forward: true);
            ManagerLogger(message: $"[id{Common.GetUserVkApi().UserId.Value}|Error]\n{ex}");
        }
    }
}