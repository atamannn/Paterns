using System;

namespace ObserverWithEvent
{
    class ConcreteObserverA : IObserver
    {
        public void Update(int subject)
        {
            if (subject > 5)
            {
                Console.WriteLine("\nsubject > 5");
            }
        }
    }
}
