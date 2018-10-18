using System;
using System.Collections.Generic;
namespace JoyEngine
{
    public enum EventsColors { WHITE_EVENT = 0, BLUE_EVENT = 1, GREEN_EVENT = 2, YELLOW_EVENT = 3, RED_EVENT = 4, BLACK_EVENT = 5, GREY_EVENT = 6};
    public enum BoardStyle { Default, Black, Color };
    public enum BoardType { Line, Circle, Grid };
    public delegate void UEvent();
    #region Scenes
    public class Scene:FactoryProduct
    {
        public event UEvent UserEvent;
        public SceneEvent sceneevent;
        internal static int id_scene;
        public int ID
        {
            get { return id_scene; }
            private set { }
        }
        internal int _type;
        public int Type
        {
            get { return _type; }
            private set { }
        }
        public Scene(string name, int type)
        {
            id_scene++;
            Name = name;
            _type = type;
        }
        public void OnUserEvent()
        {
            UserEvent += sceneevent.SceneAction;
            UserEvent();
        }
    }
    public abstract class SceneEvent
    {
        public abstract void SceneAction();
    }
    public class WhiteEvent : SceneEvent
    {
        public override void SceneAction()
        {
            Console.WriteLine("White");
        }
    }
    public class BlackEvent : SceneEvent
    {
        public override void SceneAction()
        {
            Console.WriteLine("Black");
        }
    }
    public class YellowEvent : SceneEvent
    {
        public override void SceneAction()
        {
            Console.WriteLine("Yellow");
        }
    }
    public class BlueEvent : SceneEvent
    {
        public override void SceneAction()
        {
            Console.WriteLine("Blue");
        }
    }
    public class RedEvent : SceneEvent
    {
        public override void SceneAction()
        {
            Console.WriteLine("Red");
        }
    }
    public class GreenEvent : SceneEvent
    {
        public override void SceneAction()
        {
            Console.WriteLine("Green");
        }
    }
    public class GrayEvent : SceneEvent
    {
        public override void SceneAction()
        {
            Console.WriteLine("Gray");
        }
    }
    #endregion
    #region Boards
    public abstract class Board : FactoryProduct
    {
        internal int _scenescount;
        internal int id_board;
        public int ID
        {
            get { return id_board; }
            private set { }
        }
        public BoardStyle Board_Style;
        public BoardType Board_Type;
        public int ScenesCount
        {
            get { return _scenescount; }
            private set { }
        }
        public List<Scene> Scenes = new List<Scene>();
    }
    public class SprintBoard : Board
    {
        public SprintBoard(List<Scene> scenes)
        {
            _scenescount = scenes.Count;
            id_board++;
            Board_Style = BoardStyle.Default;
            Board_Type = BoardType.Line;
            Scenes = scenes;
        }
    }
    #endregion
    
}
