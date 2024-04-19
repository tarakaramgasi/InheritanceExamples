using Parent;
namespace Child1
{
    public class ChildClass1 : ParentClass
    {
        public ChildClass1(string message):base(message)
        {
            Console.WriteLine("This is child class 1");
        }

        public override void Display(string message)
        {
            Console.WriteLine("This is Overrided display method");
        }
    }
}
