using JoyEngine;
using PokerCORE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerExampleOnJE
{
    class RoomManager:Singleton<RoomManager>,IProcessController
    {
      static List<Room> rooms=new List<Room>();
        public List<Room> Rooms { get { return rooms; } }
        public TableWindow tw;
        public Table GetActiveTable()
        {

            return rooms.Last().tables.Last();
        }
        public void CreateRoom()
      {
           rooms.Add(new Room(new List<Table>(), new List<PokerPlayer>()));
           OnRoomCreated();      
      }
        private void OnRoomCreated()
        {
           TableWindow tw = new TableWindow();
           tw.Show();

        }
        public void EndLevel()
        {
            throw new NotImplementedException();
        }
        public void IntializeLevel()
        {
            CreateRoom();
            rooms.Last().AddTable();
        }

        public void RestartLevel()
        {
            throw new NotImplementedException();
        }

        public void ShowControllerInfo()
        {
            throw new NotImplementedException();
        }

        public void StartLevel()
        {
            rooms.Last().AddPlayers(PokerCORE.PlayerManager.Instance.Players);
            tw = new TableWindow();
           // tw.Show();          
        }

        public void StopLevel()
        {
            throw new NotImplementedException();
        }
    }
}
