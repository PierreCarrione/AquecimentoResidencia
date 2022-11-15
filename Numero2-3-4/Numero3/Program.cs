using System;

public class NotTriangle : Exception
{
    public NotTriangle(String message)
        : base(message) { }
}
public enum type { EQUILÁTERO, ISÓSCELES, ESCALENO}
public class Triangulo
{
    Vertice v1;
    Vertice v2;
    Vertice v3; 

    public void setV1(Vertice v)
    {
        v1 = v;
    }
    public void setV2(Vertice v)
    {
        v2 = v;
    }
    public void setV3(Vertice v)
    {
        v3 = v;
    }
    public Vertice getV1()
    {
        return v1;
    }
    public Vertice getV2()
    {
        return v2;
    }
    public Vertice getV3()
    {
        return v3;
    }
    //Construtor para inicializar com valores de cada ponto
    public Triangulo(float x1, float y1, float x2, float y2, float x3, float y3) {
        Vertice aux = new Vertice(x1,y1);
        double d1 = aux.Distancia(x2, y2);
        double d2 = aux.Distancia(x3, y3);
        aux.Move(x2,y2);
        double d3 = aux.Distancia(x3, y3);

        if ((d1 + d2) > d3 && (d1 + d3) > d2 && (d2 + d3) > d1)
        {
            setV1(new Vertice(x1, y1));
            setV2(new Vertice(x2, y2));
            setV3(new Vertice(x3, y3));
        }
        else
        {
            throw new NotTriangle("The vertices can't form a valid triangle");
        }

    }
    //Construtor para inicializar com os vertices
    public Triangulo(Vertice v1, Vertice v2, Vertice v3)
    {
        Vertice aux = v1;
        double d1 = aux.Distancia(v2.getX(), v2.getY());
        double d2 = aux.Distancia(v3.getX(), v3.getY());
        aux.Move(v2.getX(), v2.getY());
        double d3 = aux.Distancia(v3.getX(), v3.getY());
        if ((d1 + d2) > d3 && (d1 + d3) > d2 && (d2 + d3) > d1)
        {
            setV1(v1);
            setV2(v2);
            setV3(v3);
        }
        else
        {
            throw new NotTriangle("The vertices can't form a valid triangle");
        }
        
    }

    public type WhichTriangle()
    {
        if(getV1().Distancia(getV2().getX(), getV2().getY()) == getV1().Distancia(getV3().getX(), getV3().getY()) && 
            getV1().Distancia(getV3().getX(), getV3().getY()) == getV2().Distancia(getV3().getX(), getV3().getY()) )
        {
            return type.EQUILÁTERO;
        }
        else if (getV1().Distancia(getV2().getX(), getV2().getY()) == getV1().Distancia(getV3().getX(), getV3().getY()) ||
                    getV1().Distancia(getV3().getX(), getV3().getY()) == getV2().Distancia(getV3().getX(), getV3().getY()) ||
                        getV1().Distancia(getV2().getX(), getV2().getY()) == getV2().Distancia(getV3().getX(), getV3().getY()) )
        {
            return type.ISÓSCELES;
        }
        return type.ESCALENO;
    }
    public double Perimetro()
    {
        return getV1().Distancia(getV2().getX(), getV2().getY()) + getV1().Distancia(getV3().getX(), getV3().getY()) + getV2().Distancia(getV3().getX(), getV3().getY());
    }

    public double Area()
    {
        double a = getV1().Distancia(getV2().getX(), getV2().getY());
        double b = getV1().Distancia(getV3().getX(), getV3().getY());
        double c = getV2().Distancia(getV3().getX(), getV3().getY());
        double semiP = Perimetro() / 2;
        return Math.Sqrt(semiP * (semiP - a) * (semiP - b) * (semiP - c));
    }
    public static void Main(String[] args)
    {
        Triangulo a;
        try
        {
            a = new Triangulo(3, -6, 8, -2, -1, -1);
            Console.WriteLine(a.WhichTriangle());
        }
        catch (Exception e)
        {

            Console.WriteLine(e.Message);
        }
    }
}
