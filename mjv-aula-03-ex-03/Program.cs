using exemplo3;

//conversao
//parametro opcional
//sobrcarga de método

//Construtor da classe
Forma bolo1;

bolo1 = new Forma();
string y = bolo1.RetornaNome();
var o = bolo1.RetornaTamanho;
// Console.WriteLine(y);

// Console.WriteLine(bolo1.Xpto());
// Console.WriteLine(bolo1.Xpto("bolo1"));
Console.WriteLine(bolo1.Xpto("bolo1", "xpto"));

Forma boloDeChocolate = new Forma();
Forma boloDeCenoura = new ();

Console.WriteLine(bolo1.RetornaNome("bolo1"));
Console.WriteLine(boloDeChocolate.RetornaNome("boloDeChocolate"));
Console.WriteLine(boloDeCenoura.RetornaNome("boloDeCenoura"));



string x = "";

int i = 0;
Int16 h = 0;

double d = 123;

char c = 'c';

string s = "";

var dd = bolo1.Xpto(i: 50, y: "1", x:"Maiko");
var cc = bolo1.Xpto("1", 50, "Maiko");


(string, string) nomeComposto = bolo1.RetornaNomeNovo();
var nomeComposto1 = bolo1.RetornaNomeNovo();

Console.WriteLine(nomeComposto.Item1 + " " + nomeComposto.Item2);
