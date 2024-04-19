using Parent;
namespace Child2
{
    public class ChildClass2:ParentClass
    {
        public ChildClass2(string message) : base(message)
        {
            Console.WriteLine("This is child class 2");
        }

        public new void Display(string message)
        {
            Console.WriteLine("Message reached to childclass2:"+message);
        }
    }
}
