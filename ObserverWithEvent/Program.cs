namespace ObserverWithEvent
{
    class Program
    {
        static void Main(string[] args)
        {
            var subject = new Subject();
            
            var concreteObserverA = new ConcreteObserverA();
            var concreteObserverB = new ConcreteObserverB();
            
            subject.Notify += concreteObserverA.Update;
            subject.Notify += concreteObserverB.Update;

            subject.StateDelegate += concreteObserverA.Update;
            subject.StateDelegate += concreteObserverB.Update;

            subject.SomeBusinessLogic();
        }
    }
}