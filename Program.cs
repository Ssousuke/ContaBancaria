using System.Globalization;

namespace ContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta conta = new Conta();
            Console.Write("Entre com o número da conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Entre com o nome do títular: ");
            string nome = Console.ReadLine();

            Console.Write("Você deseja fazer um deposíto inicial? (s/n)");
            char resp = char.Parse(Console.ReadLine());

            if (resp == 's' || resp == 'S')
            {
                Console.Write("Qual valor deseja depositar? ");
                double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new Conta(numero, nome, valor);
            }
            else if (resp == 'n' || resp == 'N')
            {
                conta = new Conta(numero, nome);
            }
            else
            {
                Console.WriteLine("Responsta incorreta.");
            }

            Console.WriteLine(conta.ToString());

            Console.Write("Depositar: ");
            double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            conta.Desposito(deposito);

            Console.Write("Sacar: ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            conta.Saque(saque);

            Console.WriteLine(conta.ToString());
        }
    }
}