using System;
using System.Collections.Generic;
using VkNet;
using VkNet.Model.Attachments;
using VkNet.Model.RequestParams;
namespace PolityBot.VK
{
    public class MessageExt
    {
        /// <summary>
        /// Метод отправки сообщения
        /// </summary>
        /// <param name="api">Vk API</param>
        /// <param name="message">Текст сообщения</param>
        /// <param name="peerId">Ид чата</param>
        public static void MessageSend(VkApi api, VkNet.Model.Message data, string message = null, IEnumerable<MediaAttachment> attachment = null, bool forward = false)
        {
            MessagesSendParams msp = new MessagesSendParams
            {
                PeerId = data.PeerId
            };

            if (message != null)
                msp.Message = message;

            if (attachment != null)
                msp.Attachments = attachment;
            
            if (forward)
                msp.ForwardMessages = new[] { data.Id.Value };


            try
            {
                api.Messages.Send(msp);
            }
            catch (Exception ex)
            {
                Logger.ErrorLogger(data, ex);
            }
        }
    }
}
