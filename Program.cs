//all by RozbitiOkno - funkcions and varibles

ConsoleColor puvodníbarav1 = Console.ForegroundColor;
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("int - only numbers 123");
Console.ForegroundColor = puvodníbarav1;
//int - only numbers 123

int A = 100;
System.Console.WriteLine("Hello World! " + A );

ConsoleColor puvodníbarav2 = Console.ForegroundColor;
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("if-else funkcion");
Console.ForegroundColor = puvodníbarav2;
//if-else funkcion
if (A < 100) 
{
    Console.WriteLine("true!");
}
else 
{
    Console.WriteLine("test");
}

ConsoleColor puvodníbarav3= Console.ForegroundColor;
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Double varible + WriteLine");
Console.ForegroundColor = puvodníbarav3;
//double - only numbers like 12.123

double cena = 69.99;
Console.WriteLine("Rohlíky " + cena + " int A " + A );

ConsoleColor puvodníbarav4 = Console.ForegroundColor;
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Void funkce");
Console.ForegroundColor = puvodníbarav4;
//void test funkcion
void test()
{
    Console.WriteLine("TEST funkcion! ");
}

test();

ConsoleColor puvodníbarav5 = Console.ForegroundColor;
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Switch funkcion");
Console.ForegroundColor = puvodníbarav5;
//switch funkcion

switch (A)

{
    default: Console.WriteLine("non of those!");
    break;
    case 1:
         Console.WriteLine("Case 1");   
    break;
    case 5:
         Console.WriteLine("Case 5"); 
    break;
}

List<int> intlist = new List<int>() {1,2,3}; //normal set value
intlist.Add(5); //added value
//Console.WriteLine(string.Join(", ", intlist)); //write to conslo

//LOOPS! - verry important!
foreach (int loop in intlist)
{
    Console.WriteLine(loop);
}


 