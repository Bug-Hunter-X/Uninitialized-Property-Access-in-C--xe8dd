public class ExampleClass{
    public int MyProperty { get; set; }

    public void MyMethod() {
        // Accessing a property that hasn't been initialized
        int value = MyProperty; // This could cause a NullReferenceException if MyProperty is a reference type and not initialized
        Console.WriteLine(value);
    }
}