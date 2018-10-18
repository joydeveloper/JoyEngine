
using PokerCORE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerExampleOnJE
{
 
    public abstract class AbstractFactory
    {
        public string name;
       // public virtual Board CreateBoard(List<Scene> scenes) { return null; }
        public virtual PokerPlayer CreatePlayer(PokerPlayer.Status stat) { return null; }
        public virtual PokerPlayer CreatePlayer(PokerPlayer.Status stat, string name) { return null; }
    }
    public class AliveObjectsFactory : AbstractFactory
    {
        public AliveObjectsFactory(string _name = "AliveObjectsFactory")
        {
            name = _name;
        }
        public override PokerPlayer CreatePlayer(PokerPlayer.Status stat)
        {
            switch (stat.player)
            {
                case PokerPlayer.PT.HUMAN:
                    return new Human();
                case PokerPlayer.PT.COMP:
                    return new Comp();
                //case PokerPlayer.PT.NPC:
                //    return new NPC();
            }
            return null;
        }
        public override PokerPlayer CreatePlayer(PokerPlayer.Status stat, string _name)
        {
            switch (stat.player)
            {
                case PokerPlayer.PT.HUMAN:
                    return new Human(_name);
                case PokerPlayer.PT.COMP:
                    return new Comp(_name);
                //case PokerPlayer.PT.NPC:
                //    return new NPC(_name);
            }
            return null;
        }
    }
}
