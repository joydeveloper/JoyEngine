using PokerCORE;
using System.Collections.Generic;
using System.Linq;

namespace PokerExampleOnJE
{
    public class Room
    {
        public List<PokerPlayer> players;
        public List<Table> tables;
        private static int roomid;
        public int Id { get { return roomid; } }
        public Room(List<Table> _tables, List<PokerPlayer> _players)
        {
            players = _players;
            tables = _tables;
            roomid++;
           
        }
        public void  AddPlayers(List<PokerPlayer> plrs)
        {
            if (players.Count == 2)
            {
                players = plrs;
               // AddTable();
                RoomManager.Instance.Rooms.Last().AddTable();
            }
        }
        public void AddTable()
        {
            tables.Add(new Table(new JoyEngine.Stake(20, 10)));
        }
        public override string ToString()
        {
            return roomid.ToString();
        }
    }
}
