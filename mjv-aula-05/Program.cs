// // bool a = true;
// // bool b = false;


// // resultado = a & b; // vai testar os dois
// // resultado = a | b; //vai testar os dois
// // resultado = a ^ b;
// // resultado = !a;
// // resultado a && b;
// // resultado = a || b; //vai testar o primeiro
// // resultado = a == b; //vai testar o primeiro

// String condicao ="Bom dia";
// switch (condicao)
// {
//   case "Bom dia":
//   Console.WriteLine("bom dia para você");
//     break;
//   case "Olá":
//   Console.WriteLine("Olá! tudo bem?");
//      break;
//   case "Boa tarde":
//   Console.WriteLine("boa");
//   Console.Write("tarde");
//      break;
//   default:
//   Console.WriteLine("boa noite");
//   break;
// }

// int valor = 1;

// switch (valor)
// {
//     case 0:
//     case 1:
//     case 2:
//         Console.WriteLine("caso 0, 1, 2");
//         break;
//     case -1:
//     case -10:
//     Console.Write("caso -10");
//     break;
        
// }

// int x;
// for(x = 1; x <=1000; x++)
// {
//   Console.WriteLine($"Enviando NF {x} par Prefeitura");
//   if (x == 10)
//   {
//     //logica
//   break;
//   }
// }
Console.WriteLine("Digite o seu nome: ");
string nome = Console.ReadLine();

Console.WriteLine("Digite o valor: ");
int valor = int.Parse(Console.ReadLine());


int [] numerosLoteria = new int[60];
int[] seusNumeros = new int[6];

Random rnd = new Random();

for(int i = 0; i < 60; i++)
{
  numerosLoteria[i] = i + 1;
  // Console.WriteLine(numerosLoteria[i]);

}

while(valor >= 5)
{
  for (int selecionado = 0; selecionado < 6; selecionado++)
{
  seusNumeros[selecionado] = numerosLoteria[rnd.Next(1, 60)];
}

Console.WriteLine($"{nome} os seus numeros da loteria são:");
for (int j = 0; j < 6; j++)
{
  Console.Write(" " + seusNumeros[j]+ " ");
  // Console.WriteLine(" ");;

}


}



// int[] arrayDeInts = new int[] {
//   78, 9, 90, 76, 98, 65
// };

// foreach (int numero in arrayDeInts)
// {
//   Console.WriteLine(numeros);
// }

// string[] arrayDeString = new string [] {"item 1", "item 2", "item 3", "item 4", "item 5"};
// foreach(string texto in arrayDeString)
// {
//   Console.WriteLine(texto);
// }

// valor = 0;
// while (valor <= 10)
// {
//   Console.WriteLine(valor);
//   valor++;
// }

// valor = 0;
// do 
// {
//   Console.WriteLine(valor);
//   valor++;
// } while(valor < 10);