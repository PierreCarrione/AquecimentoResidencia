using System;

public class Application
{
    public string CheckNumber()
    {
        string aux = Console.ReadLine();

        if (aux.Length < 5)
        {
            while (aux.Length < 5)
            {
                Console.WriteLine("The name can't be less than 5 digits");
                aux = Console.ReadLine();
            }
        }
        return aux;
    }

    public long CheckCpf()
    {
        long aux = long.Parse(Console.ReadLine());

        if (aux.ToString().Length != 11)
        {
            while (aux.ToString().Length != 11)
            {
                Console.WriteLine("The cpf can't be diferent than 11 digits");
                aux = long.Parse(Console.ReadLine());
            }
        }
        return aux;
    }

    public DateTime CheckNasc()
    {
        DateTime aux = DateTime.Parse(Console.ReadLine());

        if (((DateTime.Now - aux).Days / 365) < 18)
        {
            while (((DateTime.Now - aux).Days / 365) < 18)
            {
                Console.WriteLine("You must be at least 18 years old");
                aux = DateTime.Parse(Console.ReadLine());
            }
        }

        return aux;
    }

    public float CheckRenda()
    {
        float aux = float.Parse(Console.ReadLine());

        if ((aux.ToString().Split('.').Length == 1 && aux.ToString().Split('.')[0].Length > 2) || 
            (aux.ToString().Split('.').Length == 2 && (aux.ToString().Split('.')[0].Length > 2 || aux.ToString().Split('.')[1].Length > 1)) )
        {
            while (aux.ToString().Split('.')[0].Length > 2 || (aux.ToString().Split('.').Length == 2 && aux.ToString().Split('.')[1].Length > 1) )
            {
                Console.WriteLine("The number must have 2 decimal places and a decimal after the comma");
                aux = float.Parse(Console.ReadLine());
            }
        }

        return aux;
    }

    public char CheckEstCivil()
    {
        char aux = char.Parse(Console.ReadLine());

        if (char.ToUpperInvariant('c') != char.ToUpperInvariant(aux) && char.ToUpperInvariant('s') != char.ToUpperInvariant(aux) &&
                    char.ToUpperInvariant('v') != char.ToUpperInvariant(aux) && char.ToUpperInvariant('d') != char.ToUpperInvariant(aux))
        {
            while (char.ToUpperInvariant('c') != char.ToUpperInvariant(aux) && char.ToUpperInvariant('s') != char.ToUpperInvariant(aux) &&
                    char.ToUpperInvariant('v') != char.ToUpperInvariant(aux) && char.ToUpperInvariant('d') != char.ToUpperInvariant(aux))
            {
                Console.WriteLine("Only 'c', 's' , 'v' and 'd'(upper or lower case) characters are accepted");
                aux = char.Parse(Console.ReadLine());
            }
        }

        return aux;
    }

    public int CheckDependentes()
    {
        int aux = int.Parse(Console.ReadLine());

        if (aux < 0 || aux > 10)
        {
            while (aux < 0 || aux > 10)
            {
                Console.WriteLine("The number of dependents must be between 0 and 10");
                aux = int.Parse(Console.ReadLine());
            }
        }

        return aux;
    }
    public static void Main(String[] args)
    {
        Application values = new Application();
        string nome = values.CheckNumber();
        long cpf = values.CheckCpf();
        DateTime dataNasc = values.CheckNasc();
        float rendaMensal = values.CheckRenda();
        char estCivil = values.CheckEstCivil();
        int dependentes = values.CheckDependentes();

        Console.WriteLine("Nome : " + (nome) + "\nCpf : " + (cpf) + "\nData de Nascimento : " + (dataNasc) + "\nRenda Mensal : " + (rendaMensal) +
                "\nEstado Civil : " + (estCivil) + "\nDependentes : " + (dependentes));
    }
}