string name;
string age;
string color;


Console.WriteLine("hej vad heter du?");

name = Console.ReadLine();

Console.WriteLine("Hur gammal är du?"); 

age = Console.ReadLine (); 

Console.WriteLine ("vad gillar du för färg");

color = Console.ReadLine(); 

Console.WriteLine( name + age + color); 

int a;
int.TryParse(age, out a);

Console.ReadLine(); 

if (a > 20)
{
  Console.WriteLine("Högre än fyra!");
}

if (name == "Micke")
{
  Console.WriteLine("Innehållet i variabeln name är samma som 'Micke'");

  Console.ReadLine();

  Console.WriteLine();
}