using System.Collections.Generic;
namespace JoyEngine
{
    public static class ClassCombiner
    {
        public static ClassCombinedMatrix Combine(List<ClassMatrix> clmatrixlist, MethodsBuilder method)
        {
            ClassCombinedMatrix resultmatrix = new ClassCombinedMatrix();
            int c = 0;
            {
                for (int z = 0; z < clmatrixlist.Count; z++)
                {
                    for (int i = 0; i < clmatrixlist[z]._x; i++)
                    {
                        for (int j = 0; j < clmatrixlist[z]._y; j++)
                        {
                           // resultmatrix.Add(clmatrixlist[c]);
                            c++;
                        }
                    }
                }
            }
            resultmatrix.method = method;
            return resultmatrix;
        }
        public static Molot Multiple(IronOre io, WoodStick ws)
        {
            return new Molot(io._mass + ws._mass, io._volume * 0.3 + ws._volume, ws._durability, io._mass * ws.length); 
        }
    }
}
