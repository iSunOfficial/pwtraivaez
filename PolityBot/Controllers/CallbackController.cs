using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using VkNet.Model;

namespace PolityBot.Controllers
{
    /// <summary>
    /// Контроллер CallBack
    /// </summary>
    [Route("api/[controller]")]
    public class CallbackController : Controller
    {
        [HttpPost]
        public IActionResult Get([FromBody]Updates updates)
        {
            try
            {
                // Проверка на секретный ключ 
                if (updates.Secret.ToString() != BotConfig.SecretKey)           
                    return new OkObjectResult("ok");

                switch (updates.Type)
                {
                    case "confirmation":
                        return new OkObjectResult(BotConfig.Confirmation);
                    case "message_new":
                        var msg = JsonConvert.DeserializeObject<Message>(updates.Object?.ToString());

                        if (msg.Text != "" && msg.Text.IndexOf(BotConfig.BotName) < 0) // Временный фикс
                            break;

                        Logger.ManagerLogger(updates.Object?.ToString());
                        Task.Factory.StartNew(() => VK.MessageExt.MessageSend(Common.GetGroupVkApi(), msg, Commands.CommandList.ExecuteCommand(msg).ToString()));
                        break;
                }
            }
            catch (Exception ex)
            {
                Logger.ManagerLogger(message: $"{ex}");
            }
            return new OkObjectResult("ok");
        }
    }
}
