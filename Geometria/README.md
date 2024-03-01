15. Criar uma hierarquia de classes representando formas geométricas, como Quadrado, Círculo e Triângulo. Utilize herança para criar uma classe base chamada FormaGeometrica, que contenha métodos para calcular a área e o perímetro de uma forma.


- [x] Criar classe FormaGeometrica ✅ 2024-03-01
- [x] metodo calcular area ✅ 2024-03-01
- [x] metodo calcular perimetro ✅ 2024-03-01
- [x] Criar classe Quadrado ✅ 2024-03-01
- [x] Quadrado: Override metodo area e override metodo perimetro ✅ 2024-03-01
- [x] Criar classe Círculo ✅ 2024-03-01
- [x] Circulo: Override metodo area e override metodo perimetro ✅ 2024-03-01
- [x] Criar classe Triangulo ✅ 2024-03-01
- [x] Triangulo: Override metodo area e override metodo perimetro ✅ 2024-03-01

```C#
namespace Geometria.Geometria
{
    abstract class FormaGeometrica
    {
        public abstract double CalcularArea();
        public abstract double CalcularPerimetro();
    }
}

```

```C#
namespace Geometria.Geometria
{
    internal class Quadrado : FormaGeometrica
    {
        public double Lado { get; set; }

        public override double CalcularArea()
        {
            return Lado * Lado;
        }
        public override double CalcularPerimetro()
        {
            return 4 * Lado;
        }
    }
}

```

```C#
namespace Geometria.Geometria
{
    internal class Circulo : FormaGeometrica
    {
        public double Raio { get; set; }

        public override double CalcularArea()
        {
            return Math.PI * (Raio * Raio);
        }
        public override double CalcularPerimetro()
        {
            return (2 * Math.PI) * Raio;
        }
    }
}

```

```C#
namespace Geometria.Geometria
{
    internal class Triangulo : FormaGeometrica
    {

        public double Base { get; set; }
        public double Altura { get; set; }

        public override double CalcularArea()
        {
            return Base * Altura / 2;
        }
        public override double CalcularPerimetro()
        {
            return Base + Altura + Math.Sqrt(Base * Base + Altura * Altura);
        }
    }
}

```
