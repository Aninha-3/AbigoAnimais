// Nomeando as classes para a criação do abrigo de animais
namespace AbrigoDeAnimais;

class Abrigo()
{

    public string Nome;
    public int Capacidade;
    public string Endereço;
    public string[] Especies = new string[6];

    public void Info()
    {
        Console.WriteLine($"{Nome}");
        Console.WriteLine($"{Capacidade}");
        Console.WriteLine($"{Endereço}");
        Console.WriteLine($"{Especies}");

      
   }

}
