
namespace exemplo4
{
  public class Carro {

    public static  string _123 {get;}
    public bool Ligado { get; set; }
    
    public string Nome { get; set; }

 
    public Carro()
    {
      Console.WriteLine("Inicie a classe Carro");
    }

    public Carro(string nome)
    {
      this.Nome = nome;
      Console.WriteLine("Toyota prius");
    }

    public void LigarOCarro()
    {
      Ligado = true;
    }

    public int PassarMarcha() => 100;
   

    
  }
}
