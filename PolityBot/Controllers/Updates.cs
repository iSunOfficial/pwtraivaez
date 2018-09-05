//using JetBrains.Annotations;
using Newtonsoft.Json;
using System;
namespace PolityBot
{
    [Serializable]
    public class Updates
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("object")]
        //[CanBeNull]
        public object Object { get; set; }

        [JsonProperty("secret")]
        public object Secret { get; set; }
    }
}
