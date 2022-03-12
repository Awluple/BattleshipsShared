using System.Net.WebSockets;

namespace BattleshipsShared.Models
{
    public struct JoinConfirmation
    {
        public JoinConfirmation(bool succeed, string player)
        {
            this.succeed = succeed;
            this.player = player;
        }
        public bool succeed { get; }
        public string player { get; }
    }

    public struct GameJoinInfo
    {
        public GameJoinInfo(int id, string opponentPlayer)
        {
            this.id = id;
            this.opponentPlayer = opponentPlayer;
        }
        public int id { get; }
        public string opponentPlayer { get; }
    };

    public struct GameInfo
    {
        public GameInfo(int id, int players)
        {
            this.id = id;
            this.players = players;
        }
    public int id { get; }
    public int players { get; }
    }

    public struct User
    {

        public User(string userId) {
            this.userId = userId;
        }

        public string userId { get; set; }
    }

    public struct Player
    {
        public Player(string userId, WebSocketContext WSocket) {
            this.userId = userId;
            this.WSocket = WSocket;
        }
        public string userId { get; set; }
        public WebSocketContext WSocket { get; set; }
    }
}