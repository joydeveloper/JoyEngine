
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace JoyEngine
{

    public abstract class UserType:FactoryProduct
    {
        public enum PT { HUMAN, COMP, NPC }
        private static int playercounter;
        internal PT _pt;
        public PT Player { get { return _pt; }}
        public UserType(string _name)
        {
           Name = _name;
        }
        //public PlayerType(Status stat)
        //{
        //    status = stat;
        //}
        //public PlayerType(Status stat, string _name)
        //{
        //    status = stat;
        //    Name = _name;
        //}
        //private struct Status
        //{
        //    float _HP;
        //    float _EN;
        //    float _Money;
        //    float _Food;
        //    public PT player;
        //    public Status(float HP, float EN, float Money, float Food, PT pt = PT.HUMAN)
        //    {
        //        playercounter++;
        //        _HP = HP;
        //        _EN = EN;
        //        _Money = Money;
        //        _Food = Food;
        //        player = pt;
        //    }
        //    public bool isAlive
        //    {
        //        get
        //        {
        //            if (_HP <= 0)
        //                return true;
        //            else
        //                return false;
        //        }
        //        private set { }
        //    }
        //    public bool isTired
        //    {
        //        get
        //        {
        //            if (_EN <= 0)
        //                return true;
        //            else
        //                return false;
        //        }
        //        private set { }
        //    }
        //};
        //private Status status;
        void ShowStatus() { }
        void ShowStatus(int x) { }
        public UserType() { }

    }
    public class Human : UserType
    {
        public Human() { }
        //public Human(Status stat) : base(stat) { status.player = PT.HUMAN; }
        public Human(string _name) : base(_name) { _pt = PT.HUMAN; }
    }
    public class Comp : UserType
    {
        public Comp() { }
        //public Comp(Status stat) : base(stat) { status.player = PT.COMP; }
        public Comp(string _name) : base(_name) { _pt = PT.COMP; }
    }
    public class NPC : UserType
    {
        public NPC() { }
        //public NPC(Status stat) : base(stat) { status.player = PT.NPC; }
        public NPC(string _name) : base(_name) { _pt = PT.NPC; }
    }
    
}
