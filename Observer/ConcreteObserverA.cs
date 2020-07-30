using System;

namespace Observer
{
    internal class ConcreteObserverA : IObserver
    {
        public void Update(ISubject subject)
        {
            if ((subject as Subject).State < 5)
            {
                Console.WriteLine("ConcreteObserverA: Reacted to the event");
            }       
        }
    }
}
