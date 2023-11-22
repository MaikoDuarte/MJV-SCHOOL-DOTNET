using exemplo3;

namespace exemplo3
{
  public class Forma
  {
    public string RetornaNome(string x)
    {
      return $"Meu nome é: {x}";
    }

    public (string nome, string Id) RetornaNomeNovo()
    {
      return (
        "Forma de bolo",
        Guid.NewGuid().ToString()
      );

    }
    public string RetornaNome()
    {
      return "Forma de bolo";
    }
    public int RetornaTamanho()
    {
      return 10;
    }
    public string Xpto()
    {
      return "";
    }

    public string Xpto(string x)
    {
      return x;
    }

    public string Xpto(string x, int i, string y = "000000")
    {
      return x + y;
    }
  }
}