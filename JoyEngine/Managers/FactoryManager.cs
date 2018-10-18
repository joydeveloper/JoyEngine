using System.Collections.Generic;
namespace JoyEngine
{

    public abstract class FactoryProduct
    {
        string name;
        //FactoryProduct(string _name)
        //{
        //    name = _name;

        //}
        //FactoryProduct()
        //{
        //}
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if ((value!=string.Empty))
                {
                    name = value;
                }
                else
                {
                    name = "Factory" + GetType().Name;
                }
            }
        }
    }
   public class FactoryManager:Manager
    {
        public const string FACTORY_BOARD = "BoardFactory";
        public const string FACTORY_ALIVEOBJ = "AliveObjectsFactory";
        public List<AbstractFactory> factories=new List<AbstractFactory>();
        public int FactoriesCount
        {
            get
            {
                return factories.Count;
            }           
        }
        private bool isFactoryCreated(AbstractFactory af)
        {
            if (factories.Contains(af))
                return true;
            else
            return false;
        }
        private bool isFactoryCreated(string facname)
        {
            AbstractFactory t =factories.Find(x => x.Name ==facname);
            if (t != null)
            {
                return true;
            }
            else
                return false;
        }
        public virtual AbstractFactory CreateFactory(string type)
        {
            switch (type)
            {
                case FACTORY_BOARD:
                    return new BoardFactory();
                case FACTORY_ALIVEOBJ:
                    return new AliveObjectsFactory();
  
            }
            return null;
        }
        public AbstractFactory GetFactory(string facname)
        {
            if(isFactoryCreated(facname))
                return factories.Find(x => x.Name== facname);
            else
                return null;
        }      
    }
    public abstract class AbstractFactory
    { 
        private string _name;
        public string Name { get { return _name; } set { _name = value; } }
        public virtual Board CreateBoard(List<Scene> scenes) { return null; }
        public virtual UserType CreateUser(UserType.PT stat) { return null; }
        public virtual UserType CreateUser(UserType.PT stat, string name) { return null; }
    }
    public class BoardFactory : AbstractFactory
    {
     
      public  BoardFactory()
        {
            Name = FactoryManager.FACTORY_BOARD;
         
        }
        public override Board CreateBoard(List<Scene> scenes)
        {
            return new SprintBoard(scenes);
        }
    }
    public class AliveObjectsFactory : AbstractFactory
    {   
        public AliveObjectsFactory()
        {
           Name= FactoryManager.FACTORY_ALIVEOBJ;
        }
        public override UserType CreateUser(UserType.PT stat)
        {
            switch (stat)
            {
                case UserType.PT.HUMAN:
                    return new Human();
                case UserType.PT.COMP:
                    return new Comp();
                case UserType.PT.NPC:
                    return new NPC();
            }
            return null;
        }
        public override UserType CreateUser(UserType.PT stat, string _name)
        {
            switch (stat)
            {
               case UserType.PT.HUMAN:
                    return new Human(_name);
                case UserType.PT.COMP:
                    return new Comp(_name);
                case UserType.PT.NPC:
                    return new NPC(_name);
            }
            return null;
        }
    }
}
