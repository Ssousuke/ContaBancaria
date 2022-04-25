using System.Globalization;
class Conta
{
    public int Numero { get; private set; }
    private string Nome { get; set; }
    public double Saldo { get; private set; }

    public Conta(int numero, string nome)
    {
        Numero = numero;
        Nome = nome;
    }

    public Conta(int numero, string nome, double saldo) : this(numero, nome)
    {
        Saldo = saldo;
    }
    public double Desposito(double valor)
    {
        return Saldo += valor;
    }

    public double Saque(double valor)
    {
        return Saldo -= valor;
    }

    public override string ToString()
    {
        return $"Número: {Numero}, Nome: {Nome}, Saldo: {Saldo.ToString("F2", CultureInfo.InvariantCulture)}";
    }
}