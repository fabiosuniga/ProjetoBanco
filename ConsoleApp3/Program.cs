namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Banco pessoa;
            char inicial; string nome; int numeroconta; double valor; double deposito, saque;

            Console.Write("Você deseja fazer um saque inicial? s/n : ");
            inicial = char.Parse(Console.ReadLine());

            if (inicial == 's' || inicial == 'S')
            {
                Console.Write("Digite seu nome: ");
                nome = Console.ReadLine();
                Console.Write("Digite o numero da conta: ");
                numeroconta = int.Parse(Console.ReadLine());
                Console.Write("Digite o valor do deposito inicial: ");
                valor = double.Parse(Console.ReadLine());
                pessoa = new Banco(nome, numeroconta, valor);

            }

            else
            {
                Console.Write("Digite seu nome: ");
                nome = Console.ReadLine();
                Console.Write("Digite o numero da conta: ");
                numeroconta = int.Parse(Console.ReadLine());
                pessoa = new Banco(nome, numeroconta);
            }

            Console.WriteLine(pessoa);
            Console.WriteLine();

            Console.Write("Digite quantos reais você quer depositar na conta: ");
            deposito = double.Parse(Console.ReadLine());
            pessoa.Deposito(deposito);

            Console.WriteLine(pessoa);
            Console.WriteLine();

            Console.Write("Digite quantos reais você sacar da conta: ");
            saque = double.Parse(Console.ReadLine());
            pessoa.Saque(saque);

            Console.WriteLine(pessoa);
            Console.WriteLine();

        }
    }
}
