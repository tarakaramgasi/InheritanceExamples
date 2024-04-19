using Parent;
namespace Child2
{
    public class ChildClass2:ParentClass
    {
        public ChildClass2(string message) : base(message)
        {
            Console.WriteLine("This is child class 2");
        }
    }
}
