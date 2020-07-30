namespace Adapter
{
    public class Adapter : ITarget
    {
        private readonly OldObj _oldObj;

        public Adapter(OldObj oldObj)
        {
            _oldObj = oldObj;
        }
        public string GetRequest()
        {
            return $"This is {_oldObj.GetSpecificRequest()}";
        }
    }
}
