using System;

class FichaCadastral
{
    static void Main(string[] args)
    {
        // Nome
        Console.WriteLine("Nome:");
        string nome = Console.ReadLine();

        // E-mail
        Console.WriteLine("E-mail:");
        string email = Console.ReadLine();

        // Data de Nascimento
        Console.WriteLine("Data de Nascimento:");
        DateTime dataNascimento = DateTime.Parse(Console.ReadLine());

        // Sexo ou Gênero
        Console.WriteLine("Sexo/Genero:");
        string sexo = Console.ReadLine();

        // Endereço
        Console.WriteLine("Endereco:");
        Console.WriteLine("CEP:");
        string cep = Console.ReadLine();
        Console.WriteLine("Rua:");
        string rua = Console.ReadLine();
        Console.WriteLine("Número:");
        int numero = int.Parse(Console.ReadLine());
        Console.WriteLine("Bairro:");
        string bairro = Console.ReadLine();
        Console.WriteLine("Cidade:");
        string cidade = Console.ReadLine();
        Console.WriteLine("UF:");
        string uf = Console.ReadLine();
        Console.WriteLine("País:");
        string pais = Console.ReadLine();

        // Exibindo a Ficha Cadastral
        Console.WriteLine("------------------------");
        Console.WriteLine("**Ficha Cadastral**");
        Console.WriteLine("------------------------");
        Console.WriteLine("Nome: {0}", nome);
        Console.WriteLine("E-mail: {0}", email);
        Console.WriteLine("Data de Nascimento: {0}", dataNascimento.ToString("dd/MM/yyyy"));
        Console.WriteLine("Sexo/Gênero: {0}", sexo);
        Console.WriteLine("Endereço:");
        Console.WriteLine("CEP: {0}", cep);
        Console.WriteLine("Rua: {0}", rua);
        Console.WriteLine("Numero: {0}", numero);
        Console.WriteLine("Bairro: {0}", bairro);
        Console.WriteLine("Cidade: {0}", cidade);
        Console.WriteLine("UF: {0}", uf);
        Console.WriteLine("Pais: {0}", pais);
        Console.WriteLine("------------------------");
    }
}
