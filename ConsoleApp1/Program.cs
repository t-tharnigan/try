// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

cat myCat = new cat();
myCat.name = "Whiskers";
myCat.age = 3;



myCat.meow(); // Call meow() on the instance myCat

class cat
{
    public string name;
    public int age;

    public void meow()
    {
        Console.WriteLine("Meow!");
    }
}