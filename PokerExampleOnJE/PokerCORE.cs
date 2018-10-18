using JoyEngine;
using PokerExampleOnJE;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PokerCORE
{
   
    public class GameManager : Singleton<GameManager>
    {
        public List<IProcessController> subordinates = new List<IProcessController>();
        //  public GameEngine<PokerPlayer> gameengine;
        public ICommand command;
        private bool isSetup = false;
        public bool Ready { get { return isSetup; } }
        public GameManager()
        {
            FactoryManager.Instance.CreateFactory(FactoryManager.FACTORY_ALIVEOBJ);
        }
        public virtual void Setup()
        {
            try
            {
                MessageBox.Show("ffffff");
                subordinates.Add(RoomManager.Instance);
                subordinates.Add(PlayerManager.Instance);
                Initialize();
               // gameengine = SelectEngine(GameModes.Queue);
                isSetup = true;
            }
            catch (Exception e)
            {

            }
        }
        public void CheckPlayers()
        {
           if(PlayerManager.Instance.Players.Count==2)
            {
                RoomManager.Instance.StartLevel();
            }
        }
        public virtual void ShowControlerInfo(IProcessController ic)
        {
            ic.ShowControllerInfo();
        }
        public virtual void ShowAllControlersInfo()
        {
            foreach (IProcessController oc in subordinates)
            {
                oc.ShowControllerInfo();
            }
        }
        public virtual void Initialize()
        {
            foreach (IProcessController il in subordinates)
            {
                il.IntializeLevel();
            }
        }

    }
    public abstract class PokerPlayer : FactoryProduct
    {
        public enum PT { HUMAN, COMP, NPC }
        private static int playercounter;
   
        public PokerPlayer(string _name)
        {
            Name = _name;
        }
        public PokerPlayer(Status stat)
        {
            status = stat;
        }
        public PokerPlayer(Status stat, string _name)
        {
            status = stat;
            Name = _name;
        }
        public struct Status
        {
            float _AviableMoney;
            float _currentstack;
            bool _ontable;
            public PT player;
            public Status(float AviableMoney, float currentstack, bool ontable, PT pt = PT.HUMAN)
            {
                _AviableMoney = AviableMoney;
                _currentstack = currentstack;
                _ontable = ontable;
                player = pt;
            }
            public bool isBunkCrupt
            {
                get
                {
                    if (_AviableMoney <= 0)
                        return true;
                    else
                        return false;
                }
                private set { }
            }
            public bool _isStacked
            {
                get
                {
                    if (_currentstack <= 0)
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
        public PokerPlayer() { }

    }
    public class Human : PokerPlayer
    {
        public Human() { }
        public Human(Status stat) : base(stat) { status.player = PT.HUMAN; }
        public Human(string _name) : base(_name) { status.player = PT.HUMAN; }
    }
    public class Comp : PokerPlayer
    {
        public Comp() { }
        public Comp(Status stat) : base(stat) { status.player = PT.COMP; }
        public Comp(string _name) : base(_name) { status.player = PT.COMP; }
    }
    public class Table : Container<PokerPlayer>
    {
        public Stake _stk;
        public Table(Stake stk)
        {
            _stk = stk;

        }
       public  Dealer dealer=new Dealer(new PlayingCardDeck(CardDeckTypes.FullDeck));
    }
    public class PlayerManager : Singleton<PlayerManager>, IProcessController
    {
        private List<PokerPlayer> players = new List<PokerPlayer>();
        public List<PokerPlayer> Players { get { return players; } }
        public ObservableCollection<PokerPlayer> ObservablePlayers { get
            {
                ObservableCollection<PokerPlayer> obplayers=new ObservableCollection<PokerPlayer>();
                foreach (PokerPlayer pp in players)
                {
                    obplayers.Add(pp);
                }
                return obplayers;
            }
        }
        public void OnPlayerCreate()
        {
            GameManager.Instance.CheckPlayers();
        }
        public void CreatePlayer(float AviableMoney, float currentstack,string name,PokerPlayer.PT pt )
        {
         // players.Add(FactoryManager.Instance.CreateFactory(FactoryManager.FACTORY_ALIVEOBJ).CreatePlayer(new PokerPlayer.Status(AviableMoney, currentstack,false,pt), name));
          OnPlayerCreate(); 
        }
        public void ShowControllerInfo()
        {

            //Console.WriteLine("Игроков "+players.Count);
            //foreach (PlayerType pt in players)
            //{
            //    Console.WriteLine(pt.Name);
            //}
        }
        public void IntializeLevel()
        {
            MessageBox.Show("Init");
            CreatePlayer(100, 0, "Red", PokerPlayer.PT.HUMAN);
            CreatePlayer(100, 0, "Green", PokerPlayer.PT.HUMAN);
            //Room room = new Room(new List<Table>(), new List<PokerPlayer>());
            //CreatePlayer(100, 50, 10, 5, "John");
            //CreatePlayer(88, 44, 7, 5, "Bill");
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

