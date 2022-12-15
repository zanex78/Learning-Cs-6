start:

Console.Clear();
Console.WriteLine("Choose between 'MeetAlien' or 'Multiply' or 'Quest' or 'Exit' to exit:");

string option = Console.ReadLine();

if (option == "MeetAlien")
{
    MeetAlien();
    Console.WriteLine("---------------------------");
    MeetAlien();
    Console.WriteLine("Press a key to go back to start.");
    Console.ReadKey();
    goto start;
}
else if (option == "Multiply")
{
    int result = Multiply(3, 8);
    Console.WriteLine("The result is: " + result);

    if (result % 2 == 0)
    {
        Console.WriteLine(result + "is an even number!");
    }
    else
    {
        Console.WriteLine(result + "is an uneven number!");
    }

    Thread.Sleep(500);
    Console.WriteLine("Press a key to go back to start.");
    Console.ReadKey();
    goto start;
}
else if (option == "Quest")
{
    Console.WriteLine("Enter a sentence to split: ");
    string sentence = Console.ReadLine();

    int wordcount = countwords(sentence);
    
    Console.WriteLine("There are " + wordcount + " words in that sentence.");
    
    Thread.Sleep(500);
    Console.WriteLine("Press a key to go back to start.");
    Console.ReadKey();
    goto start;
}
else if (option == "Exit")
{
    Console.WriteLine("Exiting the program...");
    Thread.Sleep(300);
}
else
{
    Console.WriteLine("You didn't pic a valid option.");
    Thread.Sleep(500);
    goto start;
}

static int Multiply(int num01, int num02)
{
    int result = num01 * num02;
    return result;
}

static void MeetAlien()
{
    Random numberGen = new Random();

    string name = "X-" + numberGen.Next(10, 9999);
    int age = numberGen.Next(10, 500);
    
    Console.WriteLine("Hi, I'm " + name);
    Console.WriteLine("I'm " + age + " years old.");
    Console.WriteLine("Oh, and I'm an alien.");
}

static int countwords(string sentence)
{
    int wordcount = sentence.Split(' ').Length;
    return wordcount;
}