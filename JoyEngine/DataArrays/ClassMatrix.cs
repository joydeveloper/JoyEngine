using System.Collections.Generic;
namespace JoyEngine
{
    public class ClassMatrix
    {
        public ElementX[,] t;
        public int _x, _y;
        public ClassMatrix(List<ElementX> list, int x, int y)
        {
            t = new ElementX[x, y];
            _x = x;
            _y = y;
            int c = 0;
            {
                for (int i = 0; i < x; i++)
                {
                    for (int j = 0; j < y; j++)
                    {

                        t[i, j] = list[c];
                        c++;
                    }
                }
            }
        }
        public string[] GetTypes()
        {
            int i = 0;
            string[] types=new string[t.Length];
            foreach (ElementX t1 in t)
            {

                types[i]=(t1.GetType().Name);
                i++;
            }
            return types;
        }
        public string[] GetInfo()
        {
            int c = 0;
            string[] info = new string[t.Length];
            for (int i = 0; i < _x; i++)
            {
                for (int j = 0; j < _y; j++)
                {

                   info[c]=t[i, j].Name;
                   c++;
                }
            }
            return info;
        }
    }
    public class ClassCombinedMatrix
    {
        public List<ClassMatrix> clmatrixlist = new List<ClassMatrix>();
        public MethodsBuilder method = new TestMethods();
        public void Add(ClassMatrix cm)
        {
            clmatrixlist.Add(cm);
        }
    }
}
