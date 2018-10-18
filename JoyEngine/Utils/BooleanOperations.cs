
namespace JoyEngine
{
    public static class BooleanOperations
    {

        public static bool IsPow2(int a)
        {
            if (a == 2) return true;
            else if (a % 2 == 0) return IsPow2(a / 2);
            else return false;
        }
    }
}

	

