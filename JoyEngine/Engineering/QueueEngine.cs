using System;
using System.Collections.Generic;
using System.Linq;
namespace JoyEngine
{
    public abstract class ProcessEngine<T> where T : UserType
    {
        public List<T> mainplayers = new List<T>();
        public virtual void AddActors(List<T> actors)
        {
            foreach (T tVar in actors)
            {
                mainplayers.Add(tVar);
            }
        }
        public virtual void AddActor(T mainactor)
        {
            mainplayers.Add(mainactor);
        }
        public virtual string[] PlayersList()
        {
            string[] s = new string[mainplayers.Count];
            int x = 0;
            foreach (T t in mainplayers)
            {

                s[x] = t.Name;
                x++;
            }
            return s;
        }
        public abstract string GetActivePlayer();
        public abstract string NextTurn();
    }
    public abstract class Process
    {
        public abstract void StartProcess();
        public abstract void PauseProcess();
        public abstract void AbortProcess();
    }
   public class GameProcess:Process
    {       
        public override void StartProcess()
        {
            Console.WriteLine("Hello my friend");
            Console.WriteLine("1.Go go go");
            Console.WriteLine("2.Return");
        }
        public override void PauseProcess()
        {
            throw new NotImplementedException();
        }
        public override void AbortProcess()
        {
            AppManager.Instance.StateControl.SetState(AppState.EnumState.Mainmenu);
        }
    }
    public class GameProcessCommand : ICommand
    {
        GameProcess gameprc;
        public GameProcessCommand(GameProcess gp)
        {
            gameprc = gp;
        }
        public void Execute()
        {
            gameprc.StartProcess();
        }
        public void Undo()
        {
            gameprc.AbortProcess();
        }
    }
    public class GameController
    {
        ICommand command;
        public GameController() { }
        public void SetCommand(ICommand com)
        {
            command = com;
        }

        public void PressStartButton()
        {
            command.Execute();
        }
        public void PressUndo()
        {
            command.Undo();
        }
    }
    public class QueueEngine : ProcessEngine<UserType>
    {
        public Queue<UserType> mainqueue = new Queue<UserType>();
        public override void AddActor(UserType mainactor)
        {
            base.AddActor(mainactor);
            mainqueue.Enqueue(mainactor);
        }
        public override void AddActors(List<UserType> actors)
        {
            base.AddActors(actors);
            foreach (UserType pt in actors)
                mainqueue.Enqueue(pt);
        }
        public override string GetActivePlayer()
        {
            return mainqueue.Peek().Name;
        }
        public override string NextTurn()
        {
            UserType pt = mainqueue.Dequeue();
            //    if (!pt.status.isAlive)
            //    {
            //        return "playerdie";
            //    }
            //    else
            //    {
            //        mainqueue.Enqueue(pt);
            //    }
            return mainqueue.Peek().Name;
            // }
        }
        public class ObjectPool<T> where T : ElementX
        {
            public static int Count;
            private static List<PoolRecord> _poolRecordList;
            public int GetCount()
            {
                return Count;
            }
            /// <summary>
            /// Class ObjectPool unit
            /// </summary>
            public class PoolRecord
            {
                public T Instance;
                public bool InUse;
                public string name;
                public PoolRecord(T go)
                {
                    Instance = go;
                    InUse = true;
                }
                public void SetTrue()
                {
                    InUse = true;
                }
                public void SetFalse()
                {
                    InUse = false;
                }
            }
            public ObjectPool()
            {
                _poolRecordList = new List<PoolRecord>();
            }
            public void SetDeleted(T go)
            {
                _poolRecordList.Find(x => x.Instance == go).SetFalse();
                go = _poolRecordList.Find(x => x.Instance == go).Instance;

            }
            public static List<T> GetPoolGameObj(ObjectPool<T> pool)
            {
                List<T> golist = new List<T>();
                for (int i = 0; i < pool.GetCount(); i++)
                {
                    golist.Add(pool.GetRecord(i).Instance);
                }
                return golist;
            }
            public void AddObjectToPool(T go)
            {
                Count++;
                var record = new PoolRecord(go);
                _poolRecordList.Add(record);
            }
            public void AddObjectsToPool(List<T> golist)
            {
                foreach (T t in golist)
                {
                    AddObjectToPool(t);
                }
            }
            public void CreateClonePool(List<T> golist)
            {
                foreach (T t in golist)
                {
                    Count++;
                    var record =
                        new PoolRecord((t)) { Instance = { Name = t.Name + "Clone" } };
                    _poolRecordList.Add(record);
                }
            }
            //TODO add update objects

            public void RefreshPool()
            {
                foreach (var pr in _poolRecordList)
                {

                    pr.InUse = true;
                }
            }
            public static List<PoolRecord> SelectObjects(string name)
            {
                return _poolRecordList.Where(pr => pr.Instance.Name == name).ToList();
            }
            public static void RefreshPool(string pool)
            {
                foreach (var pr in SelectObjects(pool))
                {

                    pr.InUse = true;
                }
            }
            public void ClearPool()
            {
                _poolRecordList.Clear();
            }
            public List<PoolRecord> Getpool()
            {
                return _poolRecordList;
            }
            public PoolRecord GetRecord(int id)
            {
                return _poolRecordList[id];
            }
            public static PoolRecord GetRecord(string name)
            {
                return _poolRecordList.Where(pr => pr.Instance.ToString() == name).First();
            }
            public void DeleteObjects()
            {
                foreach (var pr in _poolRecordList)
                    if (pr.InUse == false)
                    {

                    }
            }
        }
    }
}
