
using System;
using System.Collections.Generic;
namespace JoyEngine
{
  
    public class WorldManager : Singleton<WorldManager>
    {

    }
    public class BoardManager : Singleton<BoardManager>, IWorldConstructor,IProcessController
    {
        public List<Board> boardslist = new List<Board>();
        private List<Scene> scenelist = new List<Scene>();
        public void CreateSector()
        {
            
        }
        public void CreateSector(string name, int eventcolor)
        {
            Scene sc = new Scene(name, eventcolor);
            switch (eventcolor)
            {
                case (int)EventsColors.WHITE_EVENT:
                    sc.sceneevent = new WhiteEvent();
                    break;
                case (int)EventsColors.YELLOW_EVENT:
                    sc.sceneevent = new YellowEvent();
                    break;
                case (int)EventsColors.RED_EVENT:
                    sc.sceneevent = new RedEvent();
                    break;
                case (int)EventsColors.GREY_EVENT:
                    sc.sceneevent = new GrayEvent();
                    break;
                case (int)EventsColors.BLUE_EVENT:
                    sc.sceneevent = new BlueEvent();
                    break;
                case (int)EventsColors.GREEN_EVENT:
                    sc.sceneevent = new GreenEvent();
                    break;
                case (int)EventsColors.BLACK_EVENT:
                    sc.sceneevent = new BlackEvent();
                    break;
            }      
            scenelist.Add(new Scene(name,eventcolor));
        }
        public void CreateWorld()
        {
            CreateSector("Знакомство", 3);
            CreateSector("Подарок здоровья", 4);
            CreateSector("Подарок энергии", 1);
            CreateSector("Плохое событие", 6);
            CreateSector("Очень плохое событие", 5);
            CreateSector("Магазин", 2);
            CreateSector("Работа", 0);
           // boardslist.Add(FactoryManager.Instance.GetFactory(FactoryManager.FACTORY_BOARD).CreateBoard(scenelist));
        }
        public void EndLevel()
        {
            throw new NotImplementedException();
        }
        public void IntializeLevel()
        {
            CreateWorld();
        }
        public void RestartLevel()
        {
            throw new NotImplementedException();
        }
        public void ShowControllerInfo()
        {

        }
        public void StartLevel()
        {
            throw new NotImplementedException();
        }
        public void StopLevel()
        {
            throw new NotImplementedException();
        }
    }
}
