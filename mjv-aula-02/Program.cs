// Console.WriteLine(DateTime.Now);

// bool ? ativo;
// Console.WriteLine("Tipo de variável ativo: " + ativo);

var xx = Console.Read();
var yy = Console.ReadKey();
var yyy = Console.ReadLine();

Console.WriteLine(xx);
Console.WriteLine(yy);
// int ? ii;
// Int16 jj;
// string ss;

// Console.WriteLine(ii);
// Console.WriteLine(jj);
// Console.WriteLine(ss);


Int32 i = 0;
Int16 j = 500;
Int64 x = 500;
var idade1 = 100;
var idade2 = "100";

idade1 = 101;

Console.WriteLine("Tipo da variável idade1: " + idade1.GetType());

dynamic idade3 = 100;
Console.WriteLine("Tipo da variável idade3: " + idade3.GetType());
idade3 = "100";
Console.WriteLine("Tipo da variável idade3: " + idade3.GetType());
Object idade4 = 100;
Console.WriteLine("Tipo de variável idade4: " + idade4.GetType());
idade4 = "100";
Console.WriteLine("Tipo de variável idade4: " + idade4.GetType());


Console.WriteLine("Digite seu nome: ");
string nome = Console.ReadLine();

Console.Beep();

Console.WriteLine("Digite a sua idade");
string idade = Console.ReadLine();

//printei
Console.WriteLine($"O nome digitado foi: {nome} ");
Console.WriteLine($"A idade digitada foi: {idade} ");
Console.WriteLine($"A idade é: {idade1}");
Console.WriteLine("Aperte qualquer tecla para fecha a aplicação");
Console.Read();