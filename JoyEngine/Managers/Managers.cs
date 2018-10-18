using System;
using System.Collections.Generic;
namespace JoyEngine
{
   
 ///https://metanit.com/sharp/wpf/7.1.php
    public class Singleton<T> where T : new()
    {
        private static T instance;
        private static int id;
        public static T Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new T();

                    id++;
                }
                return instance;
            }
        }
    }
    public static class TaskManager
    {
        public const int PLAYER_MANAGER = 0;
        public const int GAME_MANAGER = 1;
        public const int UI_MANAGER = 2;
        public static void PlayersSetup()
        {
            Console.WriteLine("PlayerManager...Ok");          
        }
        public static void MainProcessSetup()
        {
            Console.WriteLine("MainProcessManager...Ok");
        }
        public static void UISetup()
        {
            Console.WriteLine("UIManager...Ok");
        }
        public static void MainMenu()
        {
           
            Console.WriteLine("1.Start game");
            Console.WriteLine("2.Options");
            Console.WriteLine("3.Exit");
        }
        public static void Init()
        {
            AppManager.Instance.managers.Add(new PlayerManager());
            AppManager.Instance.managers.Add(new ProcessManager());
            AppManager.Instance.managers.Add(new ConsoleUI());
            AppManager.Instance.managers[PLAYER_MANAGER].DoTask(TaskManager.PlayersSetup);
            AppManager.Instance.managers[GAME_MANAGER].DoTask(TaskManager.MainProcessSetup);
            AppManager.Instance.managers[GAME_MANAGER].DoTask(TaskManager.UISetup);
            Console.WriteLine("JEConsoleTest");
        }
        public static void StartProcess()
        {

            ((PlayerManager)AppManager.Instance.managers[PLAYER_MANAGER].GetManager()).CreatePlayer();
            ((GameManager)AppManager.Instance.managers[GAME_MANAGER].GetManager()).Setup();

        }
        public static void StartMainMenu()
        {
            AppManager.Instance.managers[UI_MANAGER].DoTask(MainMenu);
        }
        public static void Options()
        {

        }
        public static void Exit()
        {
            Environment.Exit(-1);
        }
        public static void Restart()
        {

        }
    }                 
    public abstract class Manager : IManager
    {        
        public Task ManagerTask{get;set;}
        public object GetManager() {       
                return this;
        }
        public void DoTask()
        {
            ManagerTask.Invoke();
        }
        public void DoTask(Task task)
        {
           task.Invoke();
        }      
    }
    public class AppManager:Singleton<AppManager>
    {
        private static AppState _appstate;
        public void SetStateAutomat(AppState appstate)
        {
            _appstate = appstate;
        }
        public AppState StateControl { get { return _appstate; } }    
        public List<IManager> managers = new List<IManager>();
        public bool Begin()
        {
            if (_appstate == null)
            {
                return false;
            }
            else
            {
                _appstate.CheckState();
                return true;
            }
        }
    }
}
