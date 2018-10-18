using System;
using System.Collections.Generic;
using System.Reflection;
namespace JoyEngine
{
    public class Substance : ElementX
    {
        public Substance(int mass, double vol, int durability) { _mass = mass; _volume = vol; _durability = durability; }
        public int _mass;
        public double _volume;
        public int _durability;
        public virtual void ShowProperties()
        {
            FieldInfo[] fi = GetType().GetFields();
            foreach (FieldInfo f in fi)
            {
                Console.WriteLine(f.Name + f.GetValue(this));
            }
        }
    }
    public class IronOre : Substance
    {
        public IronOre(int mass, double vol, int durability) : base(mass, vol, durability)
        {
        }
        public override void ShowProperties()
        {

        }
    }
    public class WoodStick : Substance
    {
        public int length;

        public WoodStick(int _mass, double _vol, int durability) : base(_mass, _vol, durability)
        {
        }
        public WoodStick(int _mass, double _vol, int durability, int _lenght) : base(_mass, _vol, durability)
        {
            length = _lenght;
        }
    }
    public class Molot : Substance
    {
        public int power;
        public List<MDelegate> specialmethods = new List<MDelegate>();
        public Molot(int _mass, double _vol, int durability) : base(_mass, _vol, durability)
        {

        }
        public Molot(int _mass, double _vol, int durability, int _power) : base(_mass, _vol, durability)
        {
            power = _power;
        }
        public void Execute(int i)
        {
            specialmethods[i].Instantiate();
        }
        public void ExecuteAll()
        {
            foreach (MDelegate sm in specialmethods)
            {
                sm.Instantiate();
            }
        }
    }
}
