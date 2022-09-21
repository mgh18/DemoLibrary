using DemoLibrary;

Console.WriteLine("What is your first name?");
string fname = Console.ReadLine();

Console.WriteLine("What is your last name?");
string lname = Console.ReadLine();


string fullname = PersonProcessor.JoinName(fname, lname);

Console.WriteLine($"your fullname is {fullname}");

