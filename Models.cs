using System.Net.WebSockets;
using BattleshipsShared.Communication;

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
        public GameJoinInfo(int id, string player)
        {
            this.id = id;
            this.player = player;
        }
        public int id { get; }
        public string player { get; }
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
    public struct UserBoard
    {
        public UserBoard(int[,] board) {
            this.board = board;
        }
        public int[,] board { get; set; }
    }

    public struct Shot
    {
        public Shot(int column, int row) {
            this.column = column;
            this.row = row;
        }
        public int column { get; set; }
        public int row { get; set; }

    }
    public struct ShotResult
    {
        public ShotResult(int column, int row, ShotStatus shotStatus) {
            this.column = column;
            this.row = row;
            this.shotStatus = shotStatus;
        }
        public int column { get; set; }
        public int row { get; set; }
        public ShotStatus shotStatus { get; set; }

    }

    public struct GameResult
    {
        public GameResult(int column, int row, ShotStatus shotStatus, int winner) {
            this.column = column;
            this.row = row;
            this.shotStatus = shotStatus;
            this.winner = winner;
        }
        public int column { get; set; }
        public int row { get; set; }
        public ShotStatus shotStatus { get; set; }
        public int winner { get; set; }
        }
}