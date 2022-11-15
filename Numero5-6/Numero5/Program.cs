using System;
using System.Data;

public class WrongTime : Exception
{
    public WrongTime(String message)
        : base(message) { }
}
public class Intervalo
{
    private readonly DateTime inicial;
    private readonly DateTime final;
    TimeSpan Duracao;
    public Intervalo(DateTime inicial, DateTime final)
    {
        if (inicial > final)
        {
            throw new WrongTime("Initial time can't be greater than final time");
        }
        else
        {
            this.inicial = inicial;
            this.final = final;
            Duracao = final - inicial;
        }
    }

    public DateTime getIinicial()
    {
        return this.inicial;    
    }

    public DateTime getFinal()
    {
        return this.final;
    }

    public TimeSpan getDuracao()
    {
        return this.Duracao;
    }
    public Boolean TemIntersecao(DateTime inicialComp, DateTime finalComp)
    {
        if ((getIinicial() <= inicialComp && inicialComp <= getFinal() ) || inicialComp <= getIinicial() && finalComp > getIinicial())
        {
            return true;
        }
        return false;
    }

    public Boolean SaoIguais(DateTime inicialComp, DateTime finalComp)
    {
        if (getIinicial() == inicialComp && getFinal() == finalComp)
        {
            return true;
        }
        return false;
    }


    public static void Main(String[] args)
    {
        Intervalo a;

        try
        {
            a = new Intervalo(new DateTime(2015, 12, 20), new DateTime(2018, 12, 31));
            Console.WriteLine(a.getIinicial());
            Console.WriteLine(a.getDuracao());
            Console.WriteLine(a.TemIntersecao(new DateTime(2013, 12, 20), new DateTime(2014, 12, 31)));
        }
        catch (Exception e)
        {

            Console.WriteLine(e.Message);
        }
    }
}