using VkNet;
using VkNet.Model;

namespace PolityBot
{
    public class Common
    {

        private static VkApi GroupVkApi;

        private static VkApi UserVkApi;

        private Common() { }

        /// <summary>
        /// Vk API группы
        /// </summary>
        /// <returns></returns>
        public static VkApi GetGroupVkApi()
        {
            if (GroupVkApi == null)
            {
                GroupVkApi = new VkApi();
                GroupVkApi.Authorize(new ApiAuthParams { AccessToken = BotConfig.AccessToken});
            }

            return GroupVkApi;
        }

        /// <summary>
        /// Vk API админа группы
        /// </summary>
        /// <returns></returns>
        public static VkApi GetUserVkApi()
        {
            if (UserVkApi == null)
            {
                UserVkApi = new VkApi();
                UserVkApi.Authorize(new ApiAuthParams { AccessToken = BotConfig.AccountToken });
            }

            return UserVkApi;
        }
    }
}
