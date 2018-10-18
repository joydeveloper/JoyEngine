using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JoyEngine;
using System.Net;

namespace ConsoleTest
{
    #region
    //class testi : ILevelController, ICommand
    //{
    //    public void EndLevel()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void Execute()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void IntializeLevel()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void RestartLevel()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void ShowControllerInfo()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void StartLevel()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void StopLevel()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void Undo()
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
    //interface IAccount
    //{
    //    int CurrentSum { get; } // Текущая сумма на счету
    //    void Put(int sum);      // Положить деньги на счет
    //    void Withdraw(int sum); // Взять со счета
    //}
    //interface IClient
    //{
    //    string Name { get; set; }
    //}
    //class Client : IAccount, IClient
    //{
    //    int _sum; // Переменная для хранения суммы
    //    public Client(string name, int sum)
    //    {
    //        Name = name;
    //        _sum = sum;
    //    }

    //    public string Name { get; set; }
    //    public int CurrentSum
    //    {
    //        get { return _sum; }
    //    }
    //    public void Put(int sum)
    //    {
    //        _sum += sum;
    //    }
    //    public void Withdraw(int sum)
    //    {
    //        if (sum <= _sum)
    //        {
    //            _sum -= sum;
    //        }
    //    }
    //}
    //class Transaction<T> where T : IAccount, IClient
    //{
    //    public void Operate(T acc1, T acc2, int sum)
    //    {
    //        if (acc1.CurrentSum >= sum)
    //        {
    //            acc1.Withdraw(sum);
    //            acc2.Put(sum);
    //            Console.WriteLine($"{acc1.Name} : {acc1.CurrentSum}\n{acc2.Name} : {acc2.CurrentSum}");
    //        }
    //    }
    //}
    //public struct l
    //{

    //    public int a;
    //    l(int _a)
    //    {
    //        a = _a;
    //    }
    //}
    //public abstract class Employe
    //{
    //    public Employe(string _n)
    //    {
    //        name = _n;
    //    }
    //    public string name;
    //    public virtual void DoWork() { Console.WriteLine(name + " Working..."); }
    //}
    //public class Driver : Employe
    //{
    //    public Driver(string _n) : base(_n)
    //    {
    //    }
    //    public override void DoWork()
    //    {
    //        Console.WriteLine(name + "Drive");
    //    }
    //}
    //public class Worker : Employe
    //{
    //    public Worker(string _n) : base(_n)
    //    {
    //    }

    //    public override void DoWork()
    //    {
    //        Console.WriteLine(name + "Work");
    //    }


    //}
    #endregion

    class Program
    {
        public enum Shade { good,normal,bad}
        static void Main(string[] args)
        {
            AppManager.Instance.SetStateAutomat(new MyAppState());
            AppManager.Instance.StateControl.SetState(AppState.EnumState.Mainmenu);
            string select=Console.ReadLine();
            switch (select)
            {
                case "1":Console.Clear();
                    Console.WriteLine("Start");
                    Console.WriteLine("_____________");
                    AppManager.Instance.StateControl.SetState(AppState.EnumState.MainProcess);
                        break;
                case "2":
                    Console.Clear();
                    Console.WriteLine("Options");
                    Console.WriteLine("_____________");
                    AppManager.Instance.StateControl.SetState(AppState.EnumState.Options);
                    break;
                case "3":
                    Console.Clear();
                    Console.WriteLine("Exit");
                    Console.WriteLine("_____________");
                    AppManager.Instance.StateControl.SetState(AppState.EnumState.End);
                    break;
            
            }
            Console.ReadLine();
        }
        //static void Main(string[] args)
        //{
        //    //PlayingCardDeck pcd = new PlayingCardDeck(CardDeckTypes.FullDeck);      
        //    //Dealer dealer = new Dealer(pcd);
        //    //dealer.Shuffle();
        //    //Console.WriteLine("Shuffled");
        //    //dealer.PrintDeck();
        //    //Console.WriteLine("SeedShuffled");
        //    //dealer.ReShuffle(RandomSpecial.GetRandom(dealer.GetCardCount()));
        //    //dealer.PrintDeck();

        //    Console.ReadLine();
        //}            
    }
}
