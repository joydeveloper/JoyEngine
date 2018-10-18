using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovingBehaviour
{
    class Bone
    {

        internal int _bonefaces; 
        internal int Modificator() { return 0; }
        public Bone(int bonefaces)
        {
            _bonefaces = bonefaces;  
        }
        public int BoneFaces
        {
            get { return _bonefaces; }
            private set { }
        }
        //A K Q J 10 9 юниты 8 7 6 5 4 2 это предметы
        public int ThrowBone()
        {
            return new Random(1).Next(0, _bonefaces + 1);
        }
        // int ThrowBones();
        //public int SetFaces(get );
        // int SetCount(int);
        // Bones();
        // Bones(int, int);
    };
}
