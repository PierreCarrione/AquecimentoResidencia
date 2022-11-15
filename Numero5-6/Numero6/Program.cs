using System;

public class ListaIntervalo
{
    List<Intervalo> intervalos = new List<Intervalo>();
    public void Add(DateTime inicial, DateTime final)
    {
        int flag = 0;

        for (int i = 0; i < intervalos.Count; i++)
        {
            if (intervalos[i].TemIntersecao(inicial, final))
            {
                flag++;
            }
        }
        if ( flag == 0)
        {
            intervalos.Add(new Intervalo(inicial,final));
        }
    }

    public void Imprime()
    {
        Intervalo aux;
        int y = 1;

        for (int i = 0; i < intervalos.Count-1; i++)
        {
            for (y = 1; y < intervalos.Count;y++)
            {
                if (intervalos[i].getFinal() > intervalos[y].getIinicial())
                {
                    aux = intervalos[y];
                    intervalos[y] = intervalos[i];
                    intervalos[i] = aux;
                }
            }
            y++;
        }
        for (int i = 0; i < intervalos.Count; i++)
        {
            Console.WriteLine("{0} {1}", intervalos[i].getIinicial(), intervalos[i].getFinal());
        }
    }

    public static void Main(String[] args)
    {
        ListaIntervalo lista = new ListaIntervalo();
        lista.Add(new DateTime(2015, 12, 20), new DateTime(2016, 12, 31));
        lista.Add(new DateTime(2017, 12, 20), new DateTime(2018, 12, 31));
        lista.Add(new DateTime(2012, 12, 20), new DateTime(2013, 12, 31));

        lista.Imprime();
    }
}