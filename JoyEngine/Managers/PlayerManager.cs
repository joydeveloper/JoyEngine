
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoyEngine
{
   public class PlayerManager:Manager,IProcessController
    {
        private List<UserType> players = new List<UserType>();
        public List<UserType> GetPlayers()
        {
            return players;
        }
        public void CreatePlayer(string name="Unnamed")
        {
           // players.Add((FactoryManager.Instance.CreateFactory(FactoryManager.FACTORY_ALIVEOBJ).CreateUser(UserType.PT.HUMAN,name)));
        }

        public void ShowControllerInfo()
        {
            foreach (UserType pt in players)
            {
              Console.WriteLine(pt.Name);
            }
        }
        public void IntializeLevel()
        {
            foreach (UserType pt in players)
            {
                Console.WriteLine(pt.Name);
            }
        }
        public void StartLevel()
        {
            throw new NotImplementedException();
        }

        public void StopLevel()
        {
            throw new NotImplementedException();
        }

        public void RestartLevel()
        {
            throw new NotImplementedException();
        }

        public void EndLevel()
        {
            throw new NotImplementedException();
        }
    }
}
