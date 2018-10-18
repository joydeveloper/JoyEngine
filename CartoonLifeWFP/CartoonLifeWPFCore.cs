using JoyEngine;
using System;
using System.Windows;
using System.Windows.Controls;

namespace CartoonLifeWFP
{
    public static class CartoonLifeWPFCoreActions
    {
        public const int UI_MANAGER = 0;
        public const int PLAYER_MANAGER = 1;
        public const int GAME_MANAGER = 2;
        public static void PlayersSetup()
        {

        }
        public static void MainProcessSetup()
        {

        }
        public static void UISetup()
        {

        }
        public static void MainMenu()
        {

        }
        public static void Init()
        {
            AppManager.Instance.managers.Add(new WPFUIManager());
            AppManager.Instance.managers.Add(new PlayerManager());

           
        
           // wpff.
            //  AppManager.Instance.managers.Add(new GameManager());
            //  AppManager.Instance.managers.Add(new ConsoleUI());
            //  AppManager.Instance.managers[PLAYER_MANAGER].DoTask(PlayersSetup);
            // AppManager.Instance.managers[GAME_MANAGER].DoTask(MainProcessSetup);
            //  AppManager.Instance.managers[UI_MANAGER].DoTask(UISetup);
            // Console.WriteLine("JEConsoleTest");
        }
        public static void StartProcess()
        {

            ((PlayerManager)AppManager.Instance.managers[PLAYER_MANAGER].GetManager()).CreatePlayer();
            //   ((GameManager)AppManager.Instance.managers[GAME_MANAGER].GetManager()).Setup();

        }
        public static void StartMainMenu()
        {
            // AppManager.Instance.managers[UI_MANAGER].DoTask(MainMenu);
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
    public class CartoonAppState : AppState
    {
        public override void CheckState()
        {
            switch (State)
            {
                case EnumState.Init:
                    {
                        CartoonLifeWPFCoreActions.Init();
                        break;
                    }
                case EnumState.MainProcess:
                    {
                        CartoonLifeWPFCoreActions.StartProcess();
                        break;
                    }
                case EnumState.Mainmenu:
                    {
                        CartoonLifeWPFCoreActions.StartMainMenu();
                        break;
                    }
                case EnumState.Paused:
                    {
                        break;
                    }
                case EnumState.Options:
                    {
                        CartoonLifeWPFCoreActions.Options();
                        break;
                    }
                case EnumState.End:
                    {
                        CartoonLifeWPFCoreActions.Exit();
                        break;
                    }
                case EnumState.Restart:
                    {
                        break;
                    }
            }
        }
    }
   
  
   


}

