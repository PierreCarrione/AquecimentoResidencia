using System;

public class NumberLessOne : Exception
{
    public NumberLessOne(String message) 
       :base(message)
    {

    }
}

public class Piramide
{
    int number;

    public Piramide(int number)
    {
        if (number < 1)
        {
            throw new NumberLessOne("The number can't be less than one");
        }else
        {
            this.number = number;
        }
    }

    public void Desenha(){
        int aux = number - 1;

        for (int i = 1; i <= number; i++) {
            for (int j = 0; j < aux; j++)
            {
                Console.Write(" ");
            }
            for (int j = 0; j < i; j++)
            {
                Console.Write(j+1);
            }
            for (int j = i - 1; j > 0; j--)
            {
                Console.Write(j);
            }
            Console.WriteLine();
            aux--;
        }    
    }

    public static void Main(string[] args)
    {   
        try
        {
            Piramide a = new Piramide(8);
            a.Desenha();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}

