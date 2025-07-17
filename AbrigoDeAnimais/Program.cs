namespace AbrigoDeAnimais;

class Program
{
    static void Main(string[] args)
    {
        Abrigo PatinhasFelizes = new Abrigo();

        PatinhasFelizes.Nome = "PatinhasFelizes";
        PatinhasFelizes.Capacidade = 80;
        PatinhasFelizes.Endereço = "Rua da Glória, 290 - Cotia - SP";


        // Declarar array de string
        PatinhasFelizes.Especies[0] = "Cobra";
        PatinhasFelizes.Especies[1] = "Cavalo";
        PatinhasFelizes.Especies[2] = "Peixe";
        PatinhasFelizes.Especies[3] = "Hamster";
        PatinhasFelizes.Especies[4] = "Cachorro";
        PatinhasFelizes.Especies[5] = "Gato";

        PatinhasFelizes.Info();

        // Animal.cs

        Animal AnimaisAbrigo = new Animal("Sky", "Cavalo");
        
        AnimaisAbrigo.Idade = 2;
        AnimaisAbrigo.Comer();
        AnimaisAbrigo.Brincar("Bola 🏐");
        AnimaisAbrigo.Correr();

        string Especie = AnimaisAbrigo.EspecieAnimal();

        string NomeAni = AnimaisAbrigo.NomeAnimal();

    }
}
