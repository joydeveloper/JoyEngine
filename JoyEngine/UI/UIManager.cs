using System.Collections.Generic;
namespace JoyEngine
{
    /// <summary>
    ///  Class for create UI elements in runtime 
    /// </summary>
    public abstract class UIManager<T> : Manager
    {
        Container<T> _elements=new Container<T>();
        public virtual Container<T> GetElements
        {
          get { return _elements; }
         //UIBuilder uibuilder;
         //public virtual void CreateUI(Transform trans) { }
        }
        //Switcher2way<>
    }
    public class ConsoleUI : UIManager<string>
    {




    }
}


