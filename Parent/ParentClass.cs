namespace Parent
{
    public class ParentClass
    {
        public ParentClass(string message)
        {
            Console.WriteLine(message);
        }

        public virtual void Display(string message)
        {
            Console.WriteLine(message);
        }

        public void Display(int number)
        {
            Console.WriteLine("This is Display Method for Integer parameter for "+number);
        }

    }
}
