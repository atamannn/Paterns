namespace Facade
{
    public class Facade
    {
        private readonly Subsystem1 _subsystem1;
        private readonly Subsystem2 _subsystem2;

        public Facade(Subsystem1 subsystem1, Subsystem2 subsystem2)
        {
            _subsystem1 = subsystem1;
            _subsystem2 = subsystem2;
        }

        public string Operation()
        {
            var result = "First Operation: \n";
            result += _subsystem1.Operation1() + "  " + _subsystem2.Operation1() + "\n";
            result += "Second Operation: \n";
            result += _subsystem1.Operation2() + "  " + _subsystem2.Operation2() + "\n";
            return result;
        }
    }
}