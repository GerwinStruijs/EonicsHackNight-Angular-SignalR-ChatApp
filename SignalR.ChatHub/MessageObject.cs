using Newtonsoft.Json;
using System;

namespace SignalR.ChatHub
{
	public class MessageObject
	{
		[JsonProperty("userId")]
		public string UserId { get; set; }

        [JsonProperty("clientuniqueid")]
        public string Clientuniqueid { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("textMessage")]
        public string TextMessage { get; set; }

        [JsonProperty("date")]
        public DateTime Date { get; set; }
    }
}