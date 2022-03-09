namespace BattleshipsShared.Communication
{

    public enum RequestType
    {
        Error,
        CreateGame,
        JoinGame,
        GameCreated,
        JoinConfirmation

    }

    public struct Message
    {

        public Message(RequestType requestType, object data) {
            this.requestType = requestType;
            this.data = data;
        }

        public RequestType requestType { get; set; }
        public object data { get; set; }
    }


}