using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Player
{  
    public abstract class PlayerType
    {
        public enum PT { HUMAN, COMP, NPC }
        private static int playercounter;
        public string name;
        public PlayerType(string _name)
        {
            name = _name;
        }
        public PlayerType(Status stat)
        {
            status = stat;
        }
        public PlayerType(Status stat, string _name)
        {
            status = stat;
            name = _name;
        }
        public struct Status
        {         
            float _HP;
            float _EN;
            float _Money;
            float _Food;    
            public PT player;
            public Status(float HP, float EN, float Money,float Food, PT pt=PT.HUMAN)
            {
                playercounter++;
                _HP = HP;
                _EN = EN;
                _Money = Money;
                _Food = Food;
                player = pt;               
            }
            public bool isAlive
            {
                get
                {
                    if (_HP <= 0)
                        return true;
                    else
                        return false;
                }
                private set { }
            }
            public bool isTired
            {
                get
                {
                    if (_EN <= 0)
                        return true;
                    else
                        return false;
                }
                private set { }
            }        
        };
        internal Status status;
        void ShowStatus() { }
        void ShowStatus(int x) { }
        public PlayerType() { }
        
    }
    public class Human : PlayerType
    {
        public Human() { }
        public Human(Status stat) : base(stat) { status.player = PT.HUMAN; }
        public Human(string _name) : base(_name) { status.player= PT.HUMAN; }          
    }
    public class Comp : PlayerType
    {
        public Comp() { }
        public Comp(Status stat) : base(stat) { status.player = PT.COMP; }
        public Comp(string _name) : base(_name) { status.player = PT.COMP; }
    }
    public class NPC : PlayerType
    {
        public NPC() { }
        public NPC(Status stat) : base(stat) { status.player = PT.NPC; }
        public NPC(string _name) : base(_name) { status.player = PT.NPC;}
    } 
}
