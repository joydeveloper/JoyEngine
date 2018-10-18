using System;
using System.Collections.Generic;
namespace JoyEngine
{
    public class ProcessManager : Manager
    {
        public enum ProcessModes { Queue, RealTime, OneTurn }
        public List<IProcessController> subordinates = new List<IProcessController>();
        public ProcessEngine<UserType> gameengine;
    }
    public class GameManager :ProcessManager
    {       
        public GameController gamecontroller=new GameController();
        public GameProcess gameproc = new GameProcess();
        private bool isSetup=false;
        public bool Ready { get { return isSetup; } }
        public GameManager()
        {

        }
        public  virtual void StartProcess()
        {
            gamecontroller.SetCommand(new GameProcessCommand(gameproc));
            gamecontroller.PressStartButton();

        }
        public virtual void AbortProcess()
        {
            gamecontroller.SetCommand(new GameProcessCommand(gameproc));
            gamecontroller.PressUndo();

        }
        public virtual void Setup()
        {
            try
            {
          
                gameengine = SelectEngine(ProcessModes.Queue);
                isSetup = true;
                this.subordinates.Add((PlayerManager)AppManager.Instance.managers[TaskManager.PLAYER_MANAGER].GetManager());
                Console.WriteLine("Game Begins");
                Initialize();
             

              
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
        public virtual ProcessEngine<UserType> SelectEngine(ProcessModes gm)
        {
            switch (gm)
            {
                case (ProcessModes.Queue):
                    gameengine = new QueueEngine();
                    return gameengine;
                case (ProcessModes.OneTurn):
                    gameengine = new QueueEngine();
                    return gameengine;
                case (ProcessModes.RealTime):
                    gameengine = new QueueEngine();
                    return gameengine;
            }
            return null;
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
}
