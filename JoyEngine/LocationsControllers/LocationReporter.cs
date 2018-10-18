
using System;


namespace JoyEngine
{
    public class LocationReporter : IObserver<Location>
    {
        private IDisposable unsubscriber;
        private string instName;

        public LocationReporter(string name)
        {
            this.instName = name;
        }

        public string Name
        { get { return this.instName; } }

        public virtual void Subscribe(IObservable<Location> provider)
        {
            if (provider != null)
                unsubscriber = provider.Subscribe(this);
        }

        public virtual void OnCompleted()
        {
 
        }
        public virtual void OnError(Exception e)
        {
          
        }
        public virtual void OnNext(Location value)
        {
        
        }

        public virtual void Unsubscribe()
        {
            unsubscriber.Dispose();
        }
    }
}
