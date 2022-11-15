using System.Numerics;
public class Vertice
{
    private float x;
    private float y;

    public Vertice(float x, float y)
    {
        this.x = x;
        this.y = y;
    }

    public float getX()
    {
        return x;
    }

    public float getY()
    {
        return y;
    }

    public void setX(float x)
    {
        this.x = x;
    }

    public void setY(float y)
    {
        this.y = y;
    }
    public double Distancia(float x1, float y1)
    {
        return Math.Sqrt(Math.Pow(x1 - getX(), 2) + Math.Pow(y1 - getY(), 2));
    }

    public void Move(float x, float y)
    {
        setX(x);
        setY(y);
    }

    public Boolean AreVerticesEqual(float x1, float y1)
    {
        if (getX() == x1 && getY() == y1)
        {
            return true;
        }
        return false;
    }

    public static void Main(String[] args)
    {
        Vertice v = new Vertice(2.3F, 3.5F);
        Console.WriteLine(v.Distancia(7.1F,4.3F));
    }
}

