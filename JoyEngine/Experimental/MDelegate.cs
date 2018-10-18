using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace JoyEngine
{
    public abstract class MDelegate
    {
        public abstract void Instantiate();
    }
    public static class ExtendedMethods
    {
        public static void Hit(string message) { Console.WriteLine("Hit " + message); }
        public static void Hit(int i) { Console.WriteLine(i); }
    }
    public class StringMethod : MDelegate
    {
        public string msg;
        public StringMethod(string _msg) { msg = _msg; }
        public delegate void Printer(string s);
        protected Printer p;
        public override void Instantiate()
        {
            p = new Printer(ExtendedMethods.Hit);
            p(msg);
        }
    }
    public class IntMethod : MDelegate
    {
        public int i;
        public IntMethod(int _i) { i = _i; }
        public delegate void Inter(int s);
        protected Inter p;
        public override void Instantiate()
        {
            p = new Inter(ExtendedMethods.Hit);
            p(i);
        }
    }
}
