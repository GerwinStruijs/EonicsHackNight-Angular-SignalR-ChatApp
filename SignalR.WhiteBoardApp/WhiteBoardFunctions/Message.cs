using Newtonsoft.Json;

namespace WhiteBoardFunctions
{
    public class Message
    {
        [JsonProperty("userId")]
        public string UserId { get; set; }

        [JsonProperty("prevX")]
        public int PrevX { get; set; }

        [JsonProperty("prevY")]
        public int PrevY { get; set; }

        [JsonProperty("currentX")]
        public int CurrentX { get; set; }

        [JsonProperty("currenty")]
        public int Currenty { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }
    }


}
