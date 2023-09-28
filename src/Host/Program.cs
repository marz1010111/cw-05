using Class;

Class1 class1 = new();
Console.WriteLine("Help: r - repaet, e - exit.");

while (true)
{
    int a1 = 7;
    int b1 = a1 + 1;

    Console.WriteLine($"{nameof(b1)} = {b1}"); // 7
    Console.WriteLine($"{nameof(a1)} = {a1}"); // 8

    // prefix

    int a2 = 7;
    int b2 = ++a2;

    Console.WriteLine($"{nameof(b2)} = {b2}"); //8
    Console.WriteLine($"{nameof(a2)} = {a2}"); //8
    
    // postfix

    int a3 = 7;
    int b3 = a2++;

    Console.WriteLine($"{nameof(b3)} = {b3}"); // 7
    Console.WriteLine($"{nameof(a3)} = {a3}"); // 8






    // -------------------------------------------

    Console.Write("Your choice? > ");
    string? inputUser = Console.ReadLine();

    if (inputUser == "r")
    {
        continue;
    }
    else if (inputUser == "e")
    {
        break;
    }
}
