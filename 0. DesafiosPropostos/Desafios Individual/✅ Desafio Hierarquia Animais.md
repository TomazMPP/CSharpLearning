18. Criar uma hierarquia de classes representando animais, como Mamifero, Ave e Peixe. Utilize herança e o conceito de métodos virtuais para implementar um método EmitirSom que represente o som característico de cada tipo de animal.

- [x] Criar classe Cachorro ✅ 2024-03-01
- [x] string Au Au ✅ 2024-03-01
- [x] Criar classe Gato ✅ 2024-03-01
- [x] string Miau ✅ 2024-03-01
- [x] Criar classe Vaca ✅ 2024-03-01
- [x] string Muuuh ✅ 2024-03-01
- [x] Criar classe Animais ✅ 2024-03-01
- [x] Animais: metodo emitirSom ✅ 2024-03-01

```C#
namespace Animais.Animais
{
    public class AnimaisSom
    {

        public virtual string EmitirSom() 
        {
            return "Som de Animal";
        }
    }
}

```

```C#
namespace Animais.Animais
{
    internal class Vaca : AnimaisSom
    {

        public override string EmitirSom()
        {
            return "Muuuuh!";
        }
    }
}

```

```C#
namespace Animais.Animais
{
    internal class Gato : AnimaisSom
    {

        public override string EmitirSom()
        {
            return "Miauuu!";
        }
    }
}

```

```C#
namespace Animais.Animais
{
    internal class Cachorro : AnimaisSom
    {


        public override string EmitirSom()
        {
            return "Au Au Au";
        }
    }
}

```