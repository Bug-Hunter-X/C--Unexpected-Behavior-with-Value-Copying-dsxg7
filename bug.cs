public class MyClass
{
    public int MyProperty { get; set; }

    public MyClass(int value)
    {
        MyProperty = value;
    }

    public static void Main(string[] args)
    {
        MyClass obj1 = new MyClass(10);
        MyClass obj2 = new MyClass(obj1.MyProperty);

        obj1.MyProperty = 20;

        Console.WriteLine(obj2.MyProperty); // This will print 10, not 20
    }
}