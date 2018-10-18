using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoardLibrary;
using Player;


namespace CartoonTools
{
  
   
    //public class BoardManager : Singleton<BoardManager>
    //{
    //    public List<BoardLibrary.Scene> sclist = new List<BoardLibrary.Scene>();
    //    public List<Board> boardslist = new List<Board>();
    //    public void CreateBoard()
    //    {
    //        Test();  
    //        FactoryManager.Instance.CreateBoardFactory();
    //        boardslist.Add(FactoryManager.Factoryes[0].CreateBoard(sclist));
    //       // Console.WriteLine(boardslist[0].ScenesCount);
    //    }
    //    private void Test()
    //    {
    //        BoardLibrary.Scene sc1 = new BoardLibrary.Scene("Знакомство", (int)BoardLibrary.EventsColors.WHITE_EVENT);
    //        BoardLibrary.Scene sc2 = new BoardLibrary.Scene("Подарок", (int)BoardLibrary.EventsColors.WHITE_EVENT);
    //        sc1.sceneevent = new BoardLibrary.WhiteEvent();
    //        sc2.sceneevent = new BoardLibrary.BlackEvent();
    //        sclist.Add(sc1);
    //        sclist.Add(sc2);
          
    //    }

    //}
    //public class PlayerManager : Singleton<PlayerManager>
    //{
    //    public List<PlayerType> players=new List<PlayerType>();
    //    public void CreatePlayers()
    //    {
    //        FactoryManager.Instance.CreatePlayerFactory();
    //        PlayerType.Status humanstat = new PlayerType.Status(100, 50, 10, 5);
    //        PlayerType.Status humanstat1 = new PlayerType.Status(88, 50, 10, 5);
    //        players.Add(FactoryManager.Factoryes[1].CreatePlayer(humanstat,"Jonh"));
    //        players.Add(FactoryManager.Factoryes[1].CreatePlayer(humanstat1,"Bill"));
    //    }
    //}
    //public class GameManager : Singleton<GameManager>
    //{
    //    GameEngine<PlayerType> gameengine;
    //    public void SetupGame()
    //    {
    //        BoardManager.Instance.CreateBoard();
    //        PlayerManager.Instance.CreatePlayers();
    //        gameengine=SelectEngine(GameModes.Queue);
            
    //        ShowGameInfo();
    //    }
    //    public GameEngine<PlayerType> SelectEngine(GameModes gm)
    //    {
    //        switch (gm)
    //        {
    //            case (GameModes.Queue):
    //                gameengine=new QueueEngine<PlayerType>();
    //                gameengine.AddActors(PlayerManager.Instance.players);
    //                return gameengine;



    //        }

    //        return null;
    //    }
    //    public void ShowGameInfo()
    //    {
    //        Console.WriteLine(BoardManager.Instance.sclist.Count);
    //        Console.WriteLine(PlayerManager.Instance.players.Count);
    //        for (int i=0;i< gameengine.PlayersList().Length;i++)
    //        Console.WriteLine(gameengine.PlayersList()[i]);
    //        Console.WriteLine(gameengine.GetActivePlayer());

    //    }
       
    //}
    public interface Command
    {
       void execute();
    }
    //public class FactoryManager:Singleton<FactoryManager> 
    //{
    //    public static List<AbstractFactory> Factoryes=new List<AbstractFactory>();
    //    public void CreateBoardFactory() {
    //        Factoryes.Add(new BoardFactory());
    //    }
    //    public void CreatePlayerFactory()
    //    {
    //        Factoryes.Add(new AliveObjectsFactory());
    //    }
    //}
    //public abstract class AbstractFactory
    //{
    //    // public virtual BoardLibrary.Board CreateBoard(string type) { };
    //    public virtual BoardLibrary.Board CreateBoard(List<BoardLibrary.Scene> scenes) { return null; }
    //    public virtual PlayerType CreatePlayer(PlayerType.Status stat) { return null; }
    //    public virtual PlayerType CreatePlayer(PlayerType.Status stat, string name) { return null; }
    //    // public abstract AbstractProductB CreateProductB();
    //}


    /// <summary>
    /// The 'ConcreteFactory1' class
    /// </summary>
   //public class BoardFactory : AbstractFactory
   // {
   //     //public override Board CreateBoard(string type)
   //     //{
   //     //    throw new NotImplementedException();
   //     //}

   //     public override BoardLibrary.Board CreateBoard(List<BoardLibrary.Scene> scenes)
   //     {
            
   //         return new BoardLibrary.SprintBoard(scenes);
   //     }
     
   // }
   // public class AliveObjectsFactory : AbstractFactory
   // {
   //     //public override Board CreateBoard(string type)
   //     //{
   //     //    throw new NotImplementedException();
   //     //}

   //     public override PlayerType CreatePlayer(PlayerType.Status stat)
   //     {
            
   //         switch (stat.player)
   //         {
   //             case PlayerType.PT.HUMAN:

   //                 return new Human();
   //             case PlayerType.PT.COMP:
   //                 return new Comp();
   //             case PlayerType.PT.NPC:
   //                 return new NPC();
   //         }
   //         return null;
   //     }
   //     public override PlayerType CreatePlayer(PlayerType.Status stat,string _name)
   //     {
          
           
   //         switch (stat.player)
   //         {
                
   //             case PlayerType.PT.HUMAN:
   //                 return new Human(_name);
   //             case PlayerType.PT.COMP:
   //                 return new Comp(_name);
   //             case PlayerType.PT.NPC:
   //                 return new NPC(_name);
   //         }
   //         return null;
   //     }
   // }
  
  
}
