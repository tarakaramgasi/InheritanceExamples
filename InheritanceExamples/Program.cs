using Parent;
using Child1;
using Child2;
namespace InheritanceExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ChildClass1 child1obj = new ChildClass1("This is a Parent or Base class invoked from ChildClass1");
            //ChildClass2 child2obj = new ChildClass2("This is a Parent or Base class invoked from ChildClass2");

            //ParentClass parent = new ParentClass("This is a ParentClass");
            //parent.Display("This is Display method foe string paramenter");
            //parent.Display(100);

            ChildClass1 obj1 = new ChildClass1("Hello");
            obj1.Display("This is ChildClass1 object invoked Display method in parent class");
            obj1.Display(1000);
        }
    }
}
