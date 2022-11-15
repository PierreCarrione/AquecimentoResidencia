using System;
public class NotPolygon : Exception
{
    public NotPolygon(String message)
        : base(message) { }
}
public class Poligono
{
    List<Vertice> vertices;

    public Poligono(List<Vertice> vertices)
    {
        if (vertices.Count < 3)
        {
            throw new NotPolygon("The polygon must have at least 3 vertices");
        }
        else
        {
            this.vertices = vertices;
        }
    }

    public Boolean AddVertice(float x, float y)
    {
        int flag = 0;
        for (int i = 0; i < vertices.Count; i++)
        {
            if (vertices[i].getX() == x && vertices[i].getY() == y)
            {
                flag = 1;
            }
        }

        if (flag != 1)
        {
            vertices.Add(new Vertice(x, y));
            return true;
        }
        return false;
    }

    public void RemoveVertice(float x, float y)
    {
        for (int i = 0; i < vertices.Count; i++)
        {
            if (vertices[i].getX() == x && vertices[i].getY() == y)
            {
                if (vertices.Count - 1 < 3)
                {
                    throw new NotPolygon("The polygon must have at least 3 vertices");
                }
                else
                {
                    vertices.Remove(vertices[i]);
                }
                break;
            }
        }
    }

    public double Perimetro()
    {
        double aux = 0;

        for (int i = 0; i < vertices.Count - 1; i++)
        {
            aux = aux + vertices[i].Distancia(vertices[i+1].getX(), vertices[i + 1].getY());
        }
        return aux;
    }

    public int QtdVertices()
    {
        return vertices.Count;
    }
    public static void Main(String[] args)
    {
        List<Vertice> vertices;
        try
        {
            vertices = new List<Vertice>();
            vertices.Add(new Vertice(4, 5));
            vertices.Add(new Vertice(6, 7));
            vertices.Add(new Vertice(8, 9));
            vertices.Add(new Vertice(10, 12));
            Poligono polygon = new Poligono(vertices);
            Console.WriteLine(polygon.AddVertice(8F,9F));
            Console.WriteLine(polygon.Perimetro());
            Console.WriteLine(polygon.QtdVertices());
        }
        catch (Exception e)
        {

            Console.WriteLine(e.Message);
        }
    }
}