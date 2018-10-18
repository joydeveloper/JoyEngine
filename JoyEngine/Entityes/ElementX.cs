namespace JoyEngine
{
    public abstract class ElementX
    {
        protected string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if ((value != string.Empty))
                {
                    _name = value;
                }
                else
                {
                    _name = "Unnamed:" + GetType().Name;
                }
            }
        }
    }
}
