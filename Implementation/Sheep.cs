namespace Prototype.Implementation;

/// <summary>
/// Животное овца.
/// </summary>
public class Sheep : Animal
{
    public Sheep()
        : base(string.Empty)
    {

    }

    public Sheep(string name)
        : base(name)
    {

    }

    /// <summary>
    /// Реализация метода клонрования заключается в создании нового экземпляра овцы с добавлением Clone в ее имя.
    /// </summary>
    /// <returns></returns>
    public override Sheep MyClone()
    {
        return new Sheep($"{Name}_Clone");
    }

    public override Sheep Clone()
    {
        return MyClone();
    }
}
