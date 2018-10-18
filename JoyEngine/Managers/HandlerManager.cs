using System;
namespace JoyEngine
{
     public abstract class HandlerManager
    {
        public HandlerManager()
        {
            //Handler h1 = new ConcreteHandler1();
            //Handler h2 = new ConcreteHandler2();
            //Handler h3 = new ConcreteHandler3();
            //h1.Successor = h2;
            //h2.Successor = h3;
            //h3.HandleRequest(2);    
        }
    }
    abstract class Handler
    {
        public Handler Successor { get; set; }
        public abstract string HandleRequest(int condition);
    }
    class ConcreteHandler1 : Handler
    {
        public override string HandleRequest(int condition)
        {
            if (condition == 1)
            {
                return (condition + 1).ToString();
            }
            else if (Successor != null)
            {
                return Successor.HandleRequest(condition);
            }
            return string.Empty;
        }
    }
    class ConcreteHandler2 : Handler
    {
        public override string HandleRequest(int condition)
        {
            if (condition == 2)
            {
                return (condition + 2).ToString();
            }
            else if (Successor != null)
            {
                return Successor.HandleRequest(condition);
            }
            return string.Empty;
        }
    }
    class ConcreteHandler3 : Handler
    {
        public override string HandleRequest(int condition)
        {
            if (condition == 3)
            {
                return (condition + 3).ToString();
            }
            else if (Successor != null)
            {
                return Successor.HandleRequest(condition);
            }
            return string.Empty;
        }
    }
}
