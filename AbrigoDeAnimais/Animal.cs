namespace AbrigoDeAnimais;

class Animal
{
    public string Nome;
    public string Especie;
    public int Idade;

    public Animal(string paramNome, string paramEspecie)
    {
        Nome = paramNome;
        Especie = paramEspecie;
    }


    public void Comer()
    {
        Console.WriteLine($"{Nome} está comendo 🍎 !");
    }
    public void Brincar(string brinquedo)
    {
        Console.WriteLine($"{Nome} está brincando com o {brinquedo}");
    }

    public void Correr()
    {
        Console.WriteLine($"O {Nome} está correndo!");
    }

    public string EspecieAnimal()
    {
        return "O nome do animal é " + Nome;
    }

    public string NomeAnimal()
    {
        return "A espécie do animal é " + Especie;
    }
}