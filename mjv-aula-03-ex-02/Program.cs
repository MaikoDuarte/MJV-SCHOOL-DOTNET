int valorA = 10;
int valorB = valorA;

string x = "aaaa";
{
  
  int y = 10;

  Console.WriteLine(x);
  Console.WriteLine(y);
}


AlterarVariavelPorValor(valorA);
Console.WriteLine("alterando por valor " + valorA);

AlterarVariavelPorReferencia(ref valorB);
Console.WriteLine("alterando por referencia " + valorB);

//de forma opcional
void MetodoComParametroOpcional(int ? num)
{

}

void AlterarVariavelPorReferencia(ref int num)
{
  num = 50;


}

void AlterarVariavelPorValor(int num)
{
  num = 100;



}