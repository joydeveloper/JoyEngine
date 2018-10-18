
namespace JoyEngine
{    
    /// <summary>
    /// Automat to change gamestates 
    /// </summary>
    public class AppState  {
        public static bool isFirstStartup = true;
        public static void SetFirstStartupFalse()
        {
            isFirstStartup = false;
        }
        public enum EnumState
        {
            Init,
            Mainmenu,
            Options,
            Restart,
            MainProcess,
            Paused,
            End
        }
        protected EnumState State;
        public AppState()
        {
            SetState(EnumState.Init);
        }
        public virtual void GetApplication()
        {
            switch (State)
            {
                case EnumState.Init:

                    break;
                case EnumState.MainProcess:

                    break;
                case EnumState.End:
                    break;
            }
        }
        public virtual void SetState(EnumState gameState)
        {
            State = gameState;
            CheckState();
        }
        public virtual void CheckState()
        {
            switch (State)
            {
                case EnumState.Init:
                    {
                        System.Console.WriteLine("AppStateInit");
                        break;
                    }
                case EnumState.MainProcess:
                    {
                        break;
                    }
                case EnumState.Mainmenu:
                    {
                      
                        break;
                    }
                case EnumState.Paused:
                    {
                        break;
                    }
                case EnumState.End:
                    {
                        break;
                    }
                case EnumState.Restart:
                    {
                        break;
                    }
            }
        }
    }  
    public class MyAppState:AppState
    {
      
        public override void CheckState() { 
         switch (State)
            {
                case EnumState.Init:
                    {
                        TaskManager.Init();
                        break;
                    }
                case EnumState.MainProcess:
                    {
                        TaskManager.StartProcess();
                        break;
                    }
                case EnumState.Mainmenu:
                    {
                        TaskManager.StartMainMenu();
                        break;
                    }
                case EnumState.Paused:
                    {
                        break;
                    }
                case EnumState.Options:
                    {
                        TaskManager.Options();
                        break;
                    }
                case EnumState.End:
                    {
                        TaskManager.Exit();
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

