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
        //Method 1: Pass by reference, obj2 will reflect changes in obj1        MyClass obj2 = obj1;
        obj1.MyProperty = 20;
        Console.WriteLine(obj2.MyProperty); // This will print 20

        //Method 2: Using an updated value assignment
        MyClass obj3 = new MyClass(obj1.MyProperty);
        obj1.MyProperty = 30; 
        Console.WriteLine(obj3.MyProperty); //This will print 20
        obj3.MyProperty = obj1.MyProperty; 
        Console.WriteLine(obj3.MyProperty); //This will print 30
    }
}