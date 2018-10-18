using System;
namespace JoyEngine
{
    public delegate void Task();
    interface Iinterface
    {

    }
    public interface IWorldConstructor
    {
        void CreateWorld();
        void CreateSector(string name, int eventcolor);
    }
    public interface LifeCore
    {
        void Born();
        bool isAlive();
        double TakeDamage();
        string PartOut();
    }
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
    public interface IProcessController
    {
        void IntializeLevel();
        void StartLevel();
        void StopLevel();
        void RestartLevel();
        void EndLevel();
        void ShowControllerInfo();
    }
    public interface IObservable<T>
    {
        IDisposable Subscribe(IObserver<T> iobserver);

    }
    public interface IObserver<in T>
    {
        void OnCompleted();
        void OnError(Exception e);
        void OnNext(T value);
    }
    public interface IDealer
    {
        void Shuffle();
        object DrawCard(int order);
        object DrawTop();
        object DrawBot();
    }
   
    public interface IManager
    {
        object GetManager();
        void DoTask(Task task);
        void DoTask();
    }
    public interface PlayerActions
    {



    }
}

