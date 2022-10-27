using System.Collections.Generic;

using Newtonsoft.Json.Linq;

namespace BattleshipsShared.Communication
{

    public enum RequestType
    {
        Error,
        CreateGame,
        JoinGame,
        GameCreated,
        JoinConfirmation,
        OpponentFound,
        SetBoard,
        GameReady,
        PlayerShot,
        ShotResult,
        GameResult,
        OpponentLeft,
        OpponentConnectionLost,
        RematchProposition,
        RematchAccepted
    }

    public enum ShotStatus {
        Miss,
        Hit,
        Destroyed,
        Finished
    }
    /// <summary>Holds message type and data</summary>
    /// <param name="requestType">Type of the message</param>
    /// <param name="data">Data hold in the message</param>
    public struct Message
    {

        public Message(RequestType requestType, Dictionary<string ,object> data) {
            this.requestType = requestType;
            this.data = data;
        }

        public RequestType requestType { get; set; }
        public object data { get; set; }
        /// <summary>Deserializes data from a message to Dictionary</summary>
        /// <returns>Dictionary with the data</returns>
        public static Dictionary<string, JObject> DeserializeData(Message message) {
            JObject messageData = (JObject)message.data;
            Dictionary<string, JObject> data = messageData.ToObject<Dictionary<string, JObject>>();
            return data;
        }
    }

}