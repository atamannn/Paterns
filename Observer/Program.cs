using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            var subject = new Subject();
            var observerA = new ConcreteObserverA();
            var observerB = new ConcreteObserverB();
            subject.Attach(observerA);
            subject.Attach(observerB);

            subject.SomeBusinessLogic();
        }
    }
}